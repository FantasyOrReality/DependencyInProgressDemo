using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Purpose: Handle player damage and dying in combat*/
public class MadnessFantasyHealth : MonoBehaviour
{
    private int CurrentHealth;
    public int MaxHealth;

    private void Awake()
    {
        //The current health will be the max health each time the player spawns.
        //Implement health between scenes later
        CurrentHealth = MaxHealth;
    }

    //Action: Kill the player (for now, delete the player object)
    public void Kill()
    {
        //Destroy the object THIS script is connected to
        Destroy(gameObject);
    }

    //Action: Change our current health by a set amount
    public void ChangeHealth(int changeAmount)
    {
        CurrentHealth += changeAmount;

    }

}
