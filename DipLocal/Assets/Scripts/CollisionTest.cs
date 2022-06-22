using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    public bool isColliding = false;

    private void FixedUpdate()
    {
        //Logic for collision goes here

        if (isColliding)
        {
            //Insert output here
        }

        isColliding = false;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //The thing we ran into
        GameObject otherObject = collision.gameObject;

        //We can get the NAME of the thing
        string otherName = otherObject.name;

        //We can get the TAG of the thing
        string otherTag = otherObject.tag;

        //We can get the LAYER (Not sorting layer) of the thing
        int otherLayer = otherObject.layer;

        //We can check if a script is attached to the thing, and get it
        //(Getting a component off the other object)
        SpriteRenderer spriteRenderer = otherObject.GetComponent<SpriteRenderer>();

        //Detect if the player is colliding with itself
       
            //Output log messages
            Debug.Log("Collision activated!");
            Debug.Log("Name: " + otherName);
            Debug.Log("Tag: " + otherTag);
            Debug.Log("Layer: " + otherLayer);

            //If this thing is NOT nothing
            if (spriteRenderer != null)
            {
                //Change the color of the thing
                spriteRenderer.color = Color.blue;
            }


        }

        void OnCollisionStay2D(Collision2D collision)
        {
            //Update the collision to be true
            isColliding = true;

            Debug.Log("Collision active!");

        }


        void OnCollisionExit2D(Collision2D collision)
        {
            Debug.LogWarning("Collision de-activated!");

        }
    
}
    
