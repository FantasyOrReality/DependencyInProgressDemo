using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


//This line means that this script can only be attatched
//to a game object that has a button component on it
[RequireComponent(typeof(Button))]


//The additional items in this list let us respond to mouse or touch events
public class HeldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{

   //Variables
    private Button button;  //We will store our button here so we can use it
    private bool buttonPressed = false; //Use this to track whether the button is pressed

    //This function gets called by Unity when the user first clicks the button
    public void OnPointerDown(PointerEventData eventData)
    {
        //Ignore if the button is interactable
        if (!button.interactable)
        {
            return; //end the function
        }

        buttonPressed = true; //Record that the button is being pressed
    }

    //Called by Unity when the user releases the button
    public void OnPointerUp(PointerEventData eventData)
    {
        //Record that the button is no longer being pressed
        buttonPressed = false;
    }

    //Called by Unity when the user moves their mouse or finger off the button,
    //while it was still held down
    public void OnPointerExit(PointerEventData eventData)
    {
        //Record that the button is no longer being pressed
        buttonPressed = false;
    }

    // Awake is called before anything else on this script
    void Awake()
    {
        button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        //If we have recorded that the button has been pressed...
        if (buttonPressed == true)
        {
            //Call the onClick function set up in Unity for this button
            button.onClick?.Invoke();
        }
    }
}
