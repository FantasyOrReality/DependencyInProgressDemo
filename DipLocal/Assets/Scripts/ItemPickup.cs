using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public string ItemName = "Testing Item";


    //Called by Unity every time this object overlaps with another object
    //This is our condition
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //We only want to do anything if the other object is the player

        //We'll know they're they player if they have the Inventory script

        Inventory InventoryScript = collision.GetComponent<Inventory>();

        //Check if we actually found an Inventory script on the other object
        if (InventoryScript != null)
        {
            //This means the object was a player and we can add the item

            //Add to Inventory
            InventoryScript.ItemAdd(ItemName);

            Destroy(gameObject);

        }
    }

}
