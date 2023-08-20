using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleAnswers : MonoBehaviour
{
    public bool[,] AnswerLevel1 = new bool[6, 6];
    public int[] LevelOneX = new int[] { 0, 1, 2, 3, 4, 5 };
    public int[] LevelOneY = new int [] { 1, 3, 2, 4, 0, 5 };

    public bool[,] AnswerLevel2 = new bool[6, 6];
    public int[] LevelTwoX = new int[6] { 0, 1, 2, 3, 4, 5 };
    public int[] LevelTwoY = new int[6] { 4, 0, 3, 2, 3, 2, };

    public bool[,] AnswerLevel3 = new bool[6, 6];
    public int[] LevelThreeX = { 0, 1, 2, 3, 4, 5 };
    public int[] LevelThreeY = { 0, 0, 0, 0, 0, 0 };

    public bool[,] AnswerLevel4 = new bool[6, 6];
    public int[] LevelFourX = { 0, 1, 2, 3, 4, 5 };
    public int[] LevelFourY = { 0, 0, 0, 0, 0, 0 };

    public Puzzles puzzlesScript;
    public GameObject puzzle_script;

    public float Delay;
    public float DelaySecond;

    public int Attempts = 3;
    void Start()
    {
        puzzlesScript = puzzle_script.GetComponent<Puzzles>();
        FirstLevel();
        SecondLevel();
        ThirdLevel();
        FourthLevel();




    }

    
    void Update()
    {

        for (int i = 0; i < 6; i++)
        {
            //Debug.Log(AnswerMatrix[LevelTwoX[i], LevelTwoY[i]]);
        }
    }

    public void FirstLevel()
    {
        
        for (int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                AnswerLevel1[i,j] = false;
            }
        }

        for (int i = 0;i < 6; i++)
        {
            AnswerLevel1[ LevelOneX[i], LevelOneY[i] ] = true;
        }


    }

    public void SecondLevel()
    {
        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                AnswerLevel2[i, j] = false;
            }
        }

        for (int i = 0; i < 6; i++)
        {
            AnswerLevel2[LevelTwoX[i], LevelTwoY[i]] = true;
            
        }

   


    }
    public void ThirdLevel()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                AnswerLevel3[i, j] = false;
            }
        }

        for (int i = 0; i < 6; i++)
        {
            AnswerLevel3[LevelThreeX[i], LevelThreeY[i]] = true;
        }


    }
    public void FourthLevel()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                AnswerLevel4[i, j] = false;
            }
        }

        for (int i = 0; i < 6; i++)
        {
            AnswerLevel4[LevelFourX[i], LevelFourY[i]] = true;
        }


    }

    ////////////////////////////Level 1///////////////////////////////
    public void AnswerChecker(int X, int Y)
    {
        Debug.Log(AnswerLevel1[X, Y]);
        if (AnswerLevel1[X, Y] == true)
        {
            puzzlesScript.DeactivatePuzzles(X);
            Attempts = 3;
            Debug.Log(" If Statement works");
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
        else if (X >= 60 && X <70)
        {
            AnswerChecker(5, X - 60);
 
        }
        
    }

    /////////////////////////////////Level 2////////////////////

    public void AnswerChecker2(int X, int Y)
    {
        Debug.Log(AnswerLevel2[X, Y]);
        if (AnswerLevel2[X, Y] == true)
        {
            puzzlesScript.DeactivatePuzzles(X);
            Attempts = 3;
            Debug.Log(" If Statement works");
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
    public void answer2(int X)
    {
        if (X >= 10 && X < 20)
        {
            AnswerChecker2(0, X - 10);
        }
        else if (X >= 20 && X < 30)
        {
            AnswerChecker2(1, X - 20);
        }
        else if (X >= 30 && X < 40)
        {
            AnswerChecker2(2, X - 30);
        }
        else if (X >= 40 && X < 50)
        {
            AnswerChecker2(3, X - 40);

        }
        else if (X >= 50 && X < 60)
        {
            AnswerChecker2(4, X - 50);
        }
        else if (X >= 60 && X < 70)
        {
            AnswerChecker2(5, X - 60);

        }

    }

    ////////////////////////////Level 3/////////////////////////////////

    public void AnswerChecker3(int X, int Y)
    {
        Debug.Log(AnswerLevel3[X, Y]);
        if (AnswerLevel3[X, Y] == true)
        {
            puzzlesScript.DeactivatePuzzles(X);
            Attempts = 3;
            Debug.Log(" If Statement works");
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
    public void answer3(int X)
    {
        if (X >= 10 && X < 20)
        {
            AnswerChecker3(0, X - 10);
        }
        else if (X >= 20 && X < 30)
        {
            AnswerChecker3(1, X - 20);
        }
        else if (X >= 30 && X < 40)
        {
            AnswerChecker3(2, X - 30);
        }
        else if (X >= 40 && X < 50)
        {
            AnswerChecker3(3, X - 40);

        }
        else if (X >= 50 && X < 60)
        {
            AnswerChecker3(4, X - 50);
        }
        else if (X >= 60 && X < 70)
        {
            AnswerChecker3(5, X - 60);

        }

    }

    //////////////////////////////////Level 4////////////////////////////
    public void AnswerChecker4(int X, int Y)
    {
        Debug.Log(AnswerLevel4[X, Y]);
        if (AnswerLevel4[X, Y] == true)
        {
            puzzlesScript.DeactivatePuzzles(X);
            Attempts = 3;
            Debug.Log(" If Statement works");
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
    public void answer4(int X)
    {
        if (X >= 10 && X < 20)
        {
            AnswerChecker4(0, X - 10);
        }
        else if (X >= 20 && X < 30)
        {
            AnswerChecker4(1, X - 20);
        }
        else if (X >= 30 && X < 40)
        {
            AnswerChecker4(2, X - 30);
        }
        else if (X >= 40 && X < 50)
        {
            AnswerChecker4(3, X - 40);

        }
        else if (X >= 50 && X < 60)
        {
            AnswerChecker4(4, X - 50);
        }
        else if (X >= 60 && X < 70)
        {
            AnswerChecker4(5, X - 60);

        }

    }
}
