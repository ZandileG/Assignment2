using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    Rigidbody2D playerBody;
    Vector2 playerDirection;
    public float playerSpeed;
    public GameObject leftSprite;
    public GameObject rightSprite;
    public GameObject backSprite;
    public GameObject frontSprite;
    public Puzzles puzzlesScript;
    public GameObject puzzle_script;

    public GameObject Level4Screen;
    public GameObject WinScreen;
    public GameObject MazeGrid;
    public PuzzleAnswers puzzleAnswers;
    public GameObject AnswersScript;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        puzzlesScript = puzzle_script.GetComponent<Puzzles>();
        puzzleAnswers = AnswersScript.GetComponent<PuzzleAnswers>();

        frontSprite.SetActive(true);
        rightSprite.SetActive(false);
        backSprite.SetActive(false);
        leftSprite.SetActive(false);
    }

    void Update()
    {

        ////////////////// Player Movement////////////////////////
        playerDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        ////////////////// Sprite direction /////////////////////
        if(playerDirection.x > 0)
        {
            frontSprite.SetActive(false);
            rightSprite.SetActive(true);
            backSprite.SetActive(false);
            leftSprite.SetActive(false);
        }
        else if(playerDirection.x < 0) 
        {
            frontSprite.SetActive(false);
            rightSprite.SetActive(false);
            backSprite.SetActive(false);
            leftSprite.SetActive(true);
        }
        else if (playerDirection.y > 0)
        {
            frontSprite.SetActive(false);
            rightSprite.SetActive(false);
            backSprite.SetActive(true);
            leftSprite.SetActive(false);
        }
        else if (playerDirection.y < 0)
        {
            frontSprite.SetActive(true);
            rightSprite.SetActive(false);
            backSprite.SetActive(false);
            leftSprite.SetActive(false);
        }
        else
        {
            frontSprite.SetActive(true);
            rightSprite.SetActive(false);
            backSprite.SetActive(false);
            leftSprite.SetActive(false);
        }




    }

    private void FixedUpdate()
    {
        ////////////// Actually moving the player///////////////
        playerBody.velocity = playerDirection * playerSpeed;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        puzzlesScript.CollisionCheck(collision);

        if (collision.gameObject.tag == "Chest1")
        {
            SceneManager.LoadScene("Level2");
            puzzleAnswers.SecondLevel();
            Debug.Log("It works");
        }

        if (collision.gameObject.tag == "Chest2")
        {
            SceneManager.LoadScene("Level3");
            puzzleAnswers.ThirdLevel();
        }

        if (collision.gameObject.tag == "Chest3")
        {
            SceneManager.LoadScene("Level4");
            puzzleAnswers.FourthLevel();
        }


        if (collision.gameObject.tag == "Chest4")
        {
            WinScreen.SetActive(true);
            Level4Screen.SetActive(false);
            MazeGrid.SetActive(false);
        }

    }

}
