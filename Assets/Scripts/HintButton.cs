using UnityEngine;
using UnityEngine.UI;

public class HintButton : MonoBehaviour
{
    public GameObject answerText; // Reference to the answer text
    public GameObject hintButton; // Reference to the hint button
    public GameObject shopButton; // Reference to the shop button

    private bool shopButtonClicked = false;

    private void Start()
    {
        // Attach the button's onClick event to the ActivateAnswerText function
        Button button = hintButton.GetComponent<Button>();
        button.onClick.AddListener(ActivateAnswerText);

        Button shopBtn = shopButton.GetComponent<Button>();
        shopBtn.onClick.AddListener(OnShopButtonClicked);
    }

    public void OnShopButtonClicked()
    {
        shopButtonClicked = true;
    }

    public void ActivateAnswerText()
    {
        if (shopButtonClicked)
        {
            answerText.SetActive(true);
        }
    }
}
