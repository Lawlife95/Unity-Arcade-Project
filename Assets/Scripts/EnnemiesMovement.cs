using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesMovement : MonoBehaviour
{

    
    public Spawner spawnScript;       //a caché 
    private Collider2D coll2D;
    private Rigidbody2D rB2D;
    public bool goRightToLeft;        //a caché
    private SpriteRenderer sprite;
    

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        rB2D = GetComponent<Rigidbody2D>();
        spawnScript = transform.parent.gameObject.GetComponent <Spawner>();
        goRightToLeft = spawnScript.rightToLeft;
        coll2D = GetComponent<BoxCollider2D>();
        FlipSprite();
        StartCoroutine(SecureDelays());

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var direction = goRightToLeft ? -1 : 1;      //ternaire
        
        rB2D.velocity = new Vector2 (-direction * spawnScript.moveSpeed,0);

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

    public void FlipSprite()  //add dans un autre script + get script du spawner
    {
        if (goRightToLeft)
        {
            sprite.flipX = true;
        }
    }
   

}
