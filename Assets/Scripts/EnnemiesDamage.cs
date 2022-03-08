using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesDamage : MonoBehaviour
{
    public BoxCollider2D bC2D;

    private PlayerHealth playerHealth;      //get script du player

    void Start()
    {
        bC2D = GetComponent<BoxCollider2D>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {
            playerHealth = collision.GetComponent<PlayerHealth>();
            playerHealth.ChangeHealth(-1);
            playerHealth.Respawn();
            Destroy(gameObject);
        }

    }
    
    //appelle du make damage & respawn fonction
}
