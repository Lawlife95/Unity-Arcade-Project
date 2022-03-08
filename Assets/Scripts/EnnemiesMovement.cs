using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesMovement : MonoBehaviour
{

    
    public Spawner spawnScript;         // Script spawner
    public Collider2D coll2D;
    public Rigidbody2D rB2D;
    private bool goRightToLeft;        
    

    // Start is called before the first frame update
    void Start()
    {
        rB2D = GetComponent<Rigidbody2D>();
        spawnScript = transform.parent.gameObject.GetComponent <Spawner>();
        goRightToLeft = spawnScript.rightToLeft;
        coll2D = GetComponent<BoxCollider2D>();
        StartCoroutine(SecureDelays());
    }

    // Update is called once per frame
    void Update()
    {
        if (rB2D.velocity.x < spawnScript.maxSpeedClamp & goRightToLeft == true)
        {
            rB2D.AddForce(transform.right * spawnScript.moveSpeed, ForceMode2D.Force);    //droite vers la gauche
        } 
        if (rB2D.velocity.x > (spawnScript.maxSpeedClamp)*-1 && goRightToLeft == false)
        {
            rB2D.AddForce((transform.right * spawnScript.moveSpeed)*-1, ForceMode2D.Force);      // gauche vers la droite
        }
    }

    private IEnumerator SecureDelays()
    {
        yield return new WaitForSeconds(20f);         //Delays avant destruction
        DestroySelf();
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)           //Detection des DeadZone
    {
        if (collision.tag == "DeadZone")
        {
            DestroySelf();
        }
        
    }

    //trigger les degats sur le joueur dans un autre script

}
