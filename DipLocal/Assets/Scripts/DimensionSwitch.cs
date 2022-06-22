using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class DimensionSwitch : MonoBehaviour
{
    //Variables
    public List<GameObject> Reality;
    public List<GameObject> Fantasy;
    public GameObject RealityPlayer;
    public GameObject FantasyPlayer;
    public GameObject RealityBlock;
    public GameObject FantasyBlock;
    private bool IsReality=true;



    


    //Detect button press

    public void DimensionChange()
    {
        IsReality = !IsReality;
        /*Fantasy.SetActive(!IsReality);
        RealityPlayer.SetActive(IsReality);
        FantasyPlayer.SetActive(!IsReality);
        RealityBlock.SetActive(IsReality);
        FantasyBlock.SetActive(!IsReality);*/

        for (int i = 0; i<Reality.Count; ++i)
        {
            Reality[i].SetActive(IsReality);
        }

        for (int i = 0; i < Fantasy.Count; ++i)
        {
            Fantasy[i].SetActive(!IsReality);
        }


    }

    //Detect current dimension

    //Switch to the other dimension


}
