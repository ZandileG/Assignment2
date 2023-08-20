using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HintButton : MonoBehaviour
{
    public GameObject answerText; // Reference to the answer text
    public GameObject hintButton; // Reference to the hint button
    public Shop shopScript; // Reference to the Shop script


    private void Start()
    {
        // Attach the button's onClick event to the ActivateAnswerText function
        Button button = hintButton.GetComponent<Button>();
        button.onClick.AddListener(ActivateAnswerText);

        // Get the Shop script component
        shopScript = FindObjectOfType<Shop>();
    }

    public void ActivateAnswerText()
    {
        // Check if the player purchased an item before activating the answer text
        if (shopScript.HasPurchasedItem())
        {
            answerText.SetActive(true);
        }
    }
}
