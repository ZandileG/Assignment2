using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float startingTime = 60.0f;
    public TextMeshProUGUI timerText;
    public GameObject loseScreen;
    public GameObject levelScreen;
    public GameObject miniPuzzles;
    public GameObject mazeGrid;
    public GameObject timer;
    public GameObject currency;

    private float currentTime;
    private bool hasLost = false;

    private PuzzleAnswers puzzleAnswers; // Reference to your PuzzleAnswers script

    private void Start()
    {
        currentTime = startingTime;

        // Get a reference to the PuzzleAnswers script
        puzzleAnswers = FindObjectOfType<PuzzleAnswers>();
    }

    private void Update()
    {
        if (!hasLost && currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else if (!hasLost && currentTime <= 0)
        {
            currentTime = 0;
            UpdateTimerDisplay();
            ActivateLoseScreen();
            ResetCurrency(); // Reset the currency here
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
        loseScreen.SetActive(true);
        hasLost = true;
    }

    private void ResetCurrency()
    {
        puzzleAnswers.UpdateCurrency(0); // Set currency to 0 using the UpdateCurrency method
    }
}
