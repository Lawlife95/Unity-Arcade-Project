using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheckIsOnWater : MonoBehaviour
{
    private BoxCollider2D bC2D;
    private bool OnWater;
    private bool isOnObjectWater;
    private PlayerHealth pH;


    void Start()
    {
        bC2D = GetComponent<BoxCollider2D>();
        pH = GetComponent<PlayerHealth>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "WaterArea")
        {
            OnWater = true;
            StartCoroutine(WaterTime());
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "WaterArea")
        {
            OnWater = false;
        }
    }
  
    public IEnumerator WaterTime()
    {
        yield return new WaitForSeconds(0.3f);
        while (OnWater)
        {
            if (!isOnObjectWater)
            {
                pH.ChangeHealth(-1);
                pH.Respawn();
            }
            yield return new WaitForSeconds(0.1f);
        }


    }

    public void UpdateOnObject(bool OnObjectWater)
    {
        isOnObjectWater = OnObjectWater;
    }
}
