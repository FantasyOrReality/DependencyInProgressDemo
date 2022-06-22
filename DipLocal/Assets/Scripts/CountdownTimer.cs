using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    //Variables
    float CurrentTime = 0f;
    float StartingTime = 30f;
    [SerializeField] Text CountdownText;

    //Start the timer at the starting time
    private void Start()
    {
        CurrentTime = StartingTime;

    }

    //Decrease current time every second
    private void Update()
    {
        CurrentTime -= 1 * Time.deltaTime; //Count down every second
        CountdownText.text = CurrentTime.ToString("0"); //Show full numbers

        //Don't dip into negatives
        if (CurrentTime<=0)
        {
            CurrentTime = 0;
            SceneManager.LoadScene("LoseScreen", LoadSceneMode.Single);

        }

        if (CurrentTime<=3)
        {
            CountdownText.color = Color.magenta;
        }
        else
        {
            CountdownText.color = Color.cyan;
        }
    }
}
