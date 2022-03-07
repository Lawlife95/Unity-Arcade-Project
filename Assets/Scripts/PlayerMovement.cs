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
    private Vector3 directionTest;   //temporaire

    // Start is called before the first frame update
    void Start()
    {
        rB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void movePlayer (InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<Vector2>();
        if (obj.started)
            transform.position = new Vector2 (transform.position.x + (direction.x* moveDistance), transform.position.y + (direction.y* moveDistance));       //Destination
       
    }



}
  
