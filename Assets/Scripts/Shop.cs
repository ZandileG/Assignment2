using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public List<GameObject> ActualPuzzles = new List<GameObject>();

    public void DeactivatePuzzles(int panelNumber)
    {
        ActualPuzzles[panelNumber].SetActive(false);
    }

    //When the player wins a puzzle, they must gain gems maybe 1-5 depending on the level of difficulty
    //The player can use those gems to buy hints
    //The number of gems earned must decrease when the play presses the buy button
}
