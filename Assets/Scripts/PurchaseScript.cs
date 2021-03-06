﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseScript : MonoBehaviour
{
    public Button buyStuff;
    Item item;


    // Update is called once per frame
    void Update()
    {
        item = SelectedItem.instance.ReturnItem();
        if (item != null)
        {
            Debug.Log(item.itemName);
        }
    }


    //Called from button press, performs inventory check before CheckForBuildFrom sends it to the buy function
    public void SendToBuildCheck()
    {
       GoldControl.instance.CheckForBuildFrom(item);
    }
}
