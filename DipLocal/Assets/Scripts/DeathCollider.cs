using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollider : MonoBehaviour
{
    //How much damage this collider does to the player
    public int ColliderDamage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Get the health component from the object
        MadnessFantasyHealth MadnessFantasyHealthScript = collision.gameObject.GetComponent<MadnessFantasyHealth>();

        

        //When our collider collides with the player
        if (MadnessFantasyHealthScript !=null)
        {
            //We kill the player
            MadnessFantasyHealthScript.ChangeHealth(ColliderDamage);
        }

       void Start()
        {

        }

        void Update()
        {

        }
    }
}
