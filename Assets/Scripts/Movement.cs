using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    


    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        puzzlesScript = puzzle_script.GetComponent<Puzzles>();

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
    }

}
