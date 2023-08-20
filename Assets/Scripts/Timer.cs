using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float startingTime = 60.0f; // Starting time in seconds
    public TextMeshProUGUI timerText; // Reference to the timer text object
    public GameObject loseScreen; // Reference to the "lose" screen GameObject
    public GameObject levelScreen;
    public GameObject miniPuzzles;
    public GameObject mazeGrid;
    public GameObject timer;
    public GameObject currency;

    private float currentTime;
    private bool hasLost = false;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        if (!hasLost && currentTime > 0)
        {
            currentTime -= Time.deltaTime; // Subtract time passed since last frame
            UpdateTimerDisplay();
        }
        else if (!hasLost && currentTime <= 0)
        {
            currentTime = 0;
            UpdateTimerDisplay();
            ActivateLoseScreen();
            levelScreen.SetActive(false);
            miniPuzzles.SetActive(false);
            mazeGrid.SetActive(false);
            timer.SetActive(false);
            currency.SetActive(false);
}
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        string timerString = string.Format("{0:D2}:{1:D2}", minutes, seconds);
        timerText.text = timerString;
    }

    private void ActivateLoseScreen()
    {
        // Activate the "lose" screen GameObject
        loseScreen.SetActive(true);
        hasLost = true;
    }
}
