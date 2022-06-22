using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour

{
    public float moveSpeed = 3.0f;


    private Rigidbody2D physicsBody = null;




    // Start is called before the first frame update
    void Start()

    {
        physicsBody = GetComponent<Rigidbody2D>();

        // physicsBody.velocity = new Vector2(2, 0);

        // Update is called once per frame
    }

    // Update is called once per frame
    void Update()

    // Ask unity input manager for the current value of the horizontal axis
    // will be between -1 and 1

    {
        float axisValX = Input.GetAxis("Horizontal");
        float axisValY = Input.GetAxis("Vertical");
        Vector2 newVel = new Vector2(axisValX, axisValY);
        newVel = newVel * moveSpeed;
       // physicsBody.velocity = newVel;


    }

    public void MoveUp()
    {
        Debug.Log("Move Up Button Pressed!");

        Vector2 newVel = new Vector2(0, moveSpeed);

        physicsBody.velocity = newVel;
    }
    
    public void MoveLeft()
    {
        Debug.Log("Move Left Button Pressed!");

        Vector2 newVel = new Vector2(-moveSpeed, 0);

        physicsBody.velocity = newVel;
    }

    public void MoveRight()
    {
        Debug.Log("Move Right Button Pressed!");

        Vector2 newVel = new Vector2(moveSpeed, 0);

        physicsBody.velocity = newVel;

    }

    public void MoveDown()
    {
        Debug.Log("Move Down Button Pressed!");

        Vector2 newVel = new Vector2(0, -moveSpeed);


        physicsBody.velocity = newVel;

    }
}
