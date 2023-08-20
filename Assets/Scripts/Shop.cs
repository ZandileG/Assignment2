using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class Shop : MonoBehaviour
{
   /* public int[,] shopItems = new int[6, 6];
    public float gems;
    public TMP_Text gemTxt;

    private void Start()
    {
        gemTxt.text = "0" + gems.ToString();
        
        //Image
       // shopItems[1, 1] = 1;
       // shopItems[1, 2] = 2;
       // shopItems[1, 3] = 3;
       // shopItems[1, 4] = 4;
        //shopItems[1, 5] = 5;

        //Price
        shopItems[2, 1] = 1;
        shopItems[2, 2] = 2;
        shopItems[2, 3] = 3;
        shopItems[2, 4] = 4;
        shopItems[2, 5] = 5;

    }

    public void PurchaseHints()
    {
        GameObject BuyButton = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (gems >= shopItems[2, BuyButton.GetComponent<ShopInfo>().Image])
        {
            gems -= shopItems[2, BuyButton.GetComponent<ShopInfo>().Image];

            gemTxt.text = "Gems:" + gems.ToString();

        }

    }

    //When the player wins a puzzle, they must gain gems maybe 1-5 depending on the level of difficulty
    //The player can use those gems to buy hints
    //The number of gems earned must decrease when the play presses the buy button */
} 
