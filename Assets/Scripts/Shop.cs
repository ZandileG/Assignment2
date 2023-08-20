using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class Shop : MonoBehaviour
{
    public TextMeshProUGUI currencyText; // Reference to the currency text object
    public GameObject buyButton; // Reference to the buy button
    public int itemPrice; // Price of the item

    public GameObject insufficientFunds;
    private bool hasPurchasedItem = false;


    private void Start()
    {
        // Attach the button's onClick event to the BuyItem function
        Button button = buyButton.GetComponent<Button>();
        button.onClick.AddListener(BuyItem);
    }

    public bool HasPurchasedItem()
    {
        return hasPurchasedItem;
    }

    public void BuyItem()
    {
        int currentCurrency = int.Parse(currencyText.text);

        if (currentCurrency >= itemPrice)
        {
            currentCurrency -= itemPrice;
            UpdateCurrency(currentCurrency);
            hasPurchasedItem = true; // Update the flag
            Debug.Log("Item purchased!");
        }
        else
        {
            insufficientFunds.SetActive(true);
            StartCoroutine(DeactivateInsufficientFunds()); // Start the coroutine
        }
    }

    public void UpdateCurrency(int newCurrency)
    {
        PlayerPrefs.SetInt("Currency", newCurrency);
        PlayerPrefs.Save(); // Save the PlayerPrefs data
        currencyText.text = newCurrency.ToString();
    }

    private IEnumerator DeactivateInsufficientFunds()
    {
        yield return new WaitForSeconds(1f); // Wait for 1 second
        insufficientFunds.SetActive(false); // Deactivate the incorrectText
    }
}
