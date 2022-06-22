using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{
    public Text InventoryUpdate;


    [SerializeField]
    private List<string> Cosmetics = new List<string>();

    

    public void ItemAdd(string ItemAdded)
    {
        Cosmetics.Add(ItemAdded);

        InventoryUpdate.text = ItemAdded + " get!";

        StartCoroutine(UpdateHide());

    }

    public IEnumerator UpdateHide()
    {
        yield return new WaitForSeconds(3);
        InventoryUpdate.text = "";


    }
}
