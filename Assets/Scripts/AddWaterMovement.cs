using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddWaterMovement : MonoBehaviour
{
    private Rigidbody2D rB2D;
    private Collider2D c2D;
    private PlayerMovement playerMov;
    private EnnemiesMovement enemieMov;
    private float spawnerMov;
    private float spawnerClampMov;
    private bool onWaterObject;
    private bool rTL;
    private CheckIsOnWater cIW;

    void Start()
    {
        rB2D = GetComponent<Rigidbody2D>();
        c2D = GetComponent<Collider2D>();
        playerMov = GetComponent<PlayerMovement>();
        cIW = GetComponent<CheckIsOnWater>();
    }
    private void Update()
    {
        
        if (onWaterObject)
        {
            Debug.Log(onWaterObject);
            if (rB2D.velocity.x < spawnerClampMov & rTL == true)
            {
                rB2D.AddForce(transform.right * spawnerMov, ForceMode2D.Force);
            }
            if (rB2D.velocity.x > (spawnerClampMov) * -1 && rTL == false)
            {
                rB2D.AddForce((transform.right * spawnerMov) * -1, ForceMode2D.Force);
            }
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "WaterObject")
        {
            enemieMov = collision.gameObject.GetComponent<EnnemiesMovement>();
            spawnerMov = enemieMov.spawnScript.moveSpeed;
            spawnerClampMov = enemieMov.spawnScript.maxSpeedClamp;
            rTL = enemieMov.spawnScript.rightToLeft;
            onWaterObject = true;
            cIW.UpdateOnObject(onWaterObject);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "WaterObject")
        {
            onWaterObject = false;
            rB2D.velocity = Vector2.zero;
            cIW.UpdateOnObject(onWaterObject);
        }
    }
    
    public void DisableCollider()
    {
        c2D.enabled = false;
    }

    public void ReactivateCollider()
    {
        c2D.enabled = true;
    }

    
}
