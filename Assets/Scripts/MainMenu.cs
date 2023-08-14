using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  //This activates the "Play"button's functionality
    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }
    
  //The game will end when the "Quit" button is pressed
    public void Quit()
    {
        Application.Quit();

    } 
}
