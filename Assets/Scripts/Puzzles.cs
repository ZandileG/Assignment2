using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzles : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> puzzlePanels = new List<GameObject>();
    int puzzlePanelX;
    int puzzlePanelY;
    int playerX;
    int playerY;
    Vector2 playerPos;
    
    void Start()
    {
        for (int i = 0; i < puzzlePanels.Count; i++)
        {
            //puzzlePanels[i].SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void ActivatePuzzles(int panelNumber)
    {
        //puzzlePanels[panelNumber].SetActive(true);
    }

    public void DeactivatePuzzles(int panelNumber)
    {
        puzzlePanels[panelNumber].SetActive(false);
    }
    

    public void CollisionCheck(Collision2D Object)
    {
        if (Object.gameObject.tag == "Puzzles")
        {
            

            for (int i = 0; i < puzzlePanels.Count; i++)
            {
                playerPos = puzzlePanels[i].transform.position - player.transform.position;

                int distance = (int)playerPos.magnitude;
                if (distance <= 0.5)
                {
                    ActivatePuzzles(i);
                }

            }
        }
        Debug.Log("Collision Works");
    }
    

}
