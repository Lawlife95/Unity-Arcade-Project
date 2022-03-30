using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 direction;
    private Rigidbody2D rB2D;
    public float moveDistance;
    public float moveTime;
    

    // Start is called before the first frame update
    void Start()
    {
        rB2D = GetComponent<Rigidbody2D>();
    }


    public void movePlayer (InputAction.CallbackContext obj)
    {
        if (!obj.started)
        {
            return;
        }
        direction = obj.ReadValue<Vector2>();
        transform.position = new Vector2 (transform.position.x + (direction.x* moveDistance), transform.position.y + (direction.y* moveDistance));       //Destination
        //Test controller 
        //check X/Y valeur la plus grande
        //Move RigidBody au lieu des transforms 
    }
}
  
