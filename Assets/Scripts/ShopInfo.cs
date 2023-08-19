using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopInfo : MonoBehaviour
{
    public int ItemID;
    public TMP_Text GemTxt;
    public GameObject Shop;

    void Update ()
    {
        GemTxt.text = "Gems" + Shop.GetComponent<Shop>().shopItems[2,ItemID].ToString();
    }
}

//Please change gem text into gem icon
//This script is under the currency prefab
