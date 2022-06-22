using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDoor : MonoBehaviour
{

    public string NextScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //We overlapped with something
        //Check for player tag
        if (collision.CompareTag("Player"))
        {
            //Player confirmed

            //Switch scene
            SceneManager.LoadScene(NextScene);

        }

    }


}
