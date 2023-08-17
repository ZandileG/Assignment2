using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleAnswers : MonoBehaviour
{
    public bool[,] AnswerMatrix;
    public int[] LevelOneX = { 0, 0, 0, 0, 0, 0 };
    public int[] LevelOneY = { 0, 0, 0, 0, 0, 0 };

    public int[] LevelTwoX = { 0, 0, 0, 0, 0, 0 };
    public int[] LevelTwoY = { 0, 0, 0, 0, 0, 0 };

    public int[] LevelThreeX = { 0, 0, 0, 0, 0, 0 };
    public int[] LevelThreeY = { 0, 0, 0, 0, 0, 0 };

    public int[] LevelFourX = { 0, 0, 0, 0, 0, 0 };
    public int[] LevelFourY = { 0, 0, 0, 0, 0, 0 };

    public Puzzles puzzlesScript;
    public GameObject puzzle_script;

    public int Attempts = 3;
    void Start()
    {
        puzzlesScript = puzzle_script.GetComponent<Puzzles>();
        AnswerMatrix = new bool[6,6];
        FirstLevel();

    }

    
    void Update()
    {
        
    }

    public void FirstLevel()
    {
        for (int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                AnswerMatrix[i,j] = false;
            }
        }

        for (int i = 0;i < 5; i++)
        {
            AnswerMatrix[ LevelOneX[i], LevelOneY[i] ] = true;
        }


    }

    public void SecondLevel()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                AnswerMatrix[i, j] = false;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            AnswerMatrix[LevelTwoX[i], LevelTwoY[i]] = true;
        }


    }
    public void ThirdLevel()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                AnswerMatrix[i, j] = false;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            AnswerMatrix[LevelThreeX[i], LevelThreeY[i]] = true;
        }


    }
    public void FourthLevel()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                AnswerMatrix[i, j] = false;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            AnswerMatrix[LevelFourX[i], LevelFourY[i]] = true;
        }


    }
    public void AnswerChecker(int X, int Y)
    {
        if(AnswerMatrix[X, Y] == true)
        {
            puzzlesScript.DeactivatePuzzles(X);
            Attempts = 3;
        }
        else
        {
            //Remember to add text field for player comunication.
            //Must display incorrect answer in text field.

            Attempts--;
            if (Attempts == 0)
            {
                puzzlesScript.DeactivatePuzzles(X);
                Attempts = 3;
            }
        }
        
    }
    public void answer(int X)
    {
        if(X >= 10 &&  X < 20)
        {
            AnswerChecker(0, X - 10);
        }
        else if (X >= 20 && X < 30)
        {
            AnswerChecker(1, X - 20);
        }
        else if (X >= 30 && X < 40)
        {
            AnswerChecker(2, X - 30);
        }
        else if (X >= 40 && X < 50)
        {
            AnswerChecker(3, X - 40);
        }
        else if (X >= 50 && X < 60)
        {
            AnswerChecker(4, X - 50);
        }
        else
        {
            AnswerChecker(5, X - 60);
        }
    }
}
