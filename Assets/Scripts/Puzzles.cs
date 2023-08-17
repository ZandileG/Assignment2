using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Puzzles : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> puzzlePanels = new List<GameObject>();
    public List<GameObject> ActualPuzzels = new List<GameObject>();
    int puzzlePanelX;
    int puzzlePanelY;
    int playerX;
    int playerY;
    Vector2 playerPos;
    public GameObject TheMaze;
    public GameObject MiniPuzzles;
    public GameObject LevelScreen;
    
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
        puzzlePanels[panelNumber].SetActive(false);
        TheMaze.SetActive(false);
        ActualPuzzels[panelNumber].SetActive(true);
        MiniPuzzles.SetActive(false);
        LevelScreen.SetActive(false);

    }

    public void DeactivatePuzzles(int panelNumber)
    {
        //puzzlePanels[panelNumber].SetActive(false);
        TheMaze.SetActive(true);
        ActualPuzzels[panelNumber].SetActive(false);
        MiniPuzzles.SetActive(true);
        LevelScreen.SetActive(true);
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
        
    }
    

}
