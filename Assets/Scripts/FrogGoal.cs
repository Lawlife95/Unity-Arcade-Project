using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogGoal : MonoBehaviour
{
    private BoxCollider2D bC2D;
    private SpriteRenderer sprite;
    private bool isTrigger;
    private PlayerHealth pHealth;
    public GameObject scoreArea;
    private UIScore UIScore;
    public int ScoreGain;

    void Start()
    {
        bC2D = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        sprite.enabled = false;
        UIScore = scoreArea.GetComponent<UIScore>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            pHealth = collision.GetComponent<PlayerHealth>();
            if (!isTrigger)
                sprite.enabled = true;
                pHealth.ChangeHealth(+2);
                UIScore.scoreGain(ScoreGain);
                pHealth.addfrog(1);
                isTrigger = true;
                

            if(isTrigger)
            {
                bC2D.enabled = false;
            }
        }
    }
}
