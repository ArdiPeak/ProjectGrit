using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    private List<Card> allCards; // List of all possible cards
    private List<Card> availableCards; // List of cards that have not been generated yet
    private List<Card> generatedCards; // List of already generated cards

    void Start()
    {
        InitializeCards();
    }

    void InitializeCards()
    {
        // Initialize allCards list with all possible cards
        // Assign the appropriate prefab to each card
        allCards = new List<Card>
        {
            new Card("pencil", 1, Resources.Load<GameObject>("Prefabs/card1")),
            new Card("punch", 2, Resources.Load<GameObject>("Prefabs/card2")),
            new Card("sword", 3, Resources.Load<GameObject>("Prefabs/card3")),
            new Card("pipe", 4, Resources.Load<GameObject>("Prefabs/card4")),
            new Card("drink", 5, Resources.Load<GameObject>("Prefabs/card5")),
            new Card("shard", 6, Resources.Load<GameObject>("Prefabs/card6")),
            new Card("poison", 7, Resources.Load<GameObject>("Prefabs/card7")),
            new Card("grab", 8, Resources.Load<GameObject>("Prefabs/card8")),
            new Card("door", 9, Resources.Load<GameObject>("Prefabs/card9")),
            new Card("mirror", 10, Resources.Load<GameObject>("Prefabs/card10")),
            // Add all your cards here
        
        };

        // Check if any prefab is not loaded correctly
        foreach (Card card in allCards)
        {
            if (card.prefab == null)
            {
                Debug.LogError("Prefab for card " + card.name + " could not be loaded. Check the path and name.");
            }
        }

        // Initialize availableCards with allCards initially
        availableCards = new List<Card>(allCards);
        generatedCards = new List<Card>();
    }

    public GameObject GenerateRandomCard(Vector3 position, Transform parent)
    {
        if (availableCards.Count == 0)
        {
            return null;
        }

        // Get a random index
        int randomIndex = Random.Range(0, availableCards.Count);

        // Select the card at the random index
        Card selectedCard = availableCards[randomIndex];

        // Remove the selected card from availableCards and add it to generatedCards
        availableCards.RemoveAt(randomIndex);
        generatedCards.Add(selectedCard);

        // Check if the prefab is null before instantiating
        if (selectedCard.prefab == null)
        {
            Debug.LogError("The prefab for " + selectedCard.name + " is null. Check the initialization.");
            return null;
        }

        // Instantiate the card GameObject at the given position with the specified parent
        GameObject newCard = Instantiate(selectedCard.prefab, parent);
        newCard.name = selectedCard.name; // Assign a name to the GameObject for easier identification
        newCard.transform.localPosition = position; // Set the local position in the parent

        Debug.Log("Generated Card: " + selectedCard.name + " with value " + selectedCard.value);
        return newCard;
    }
}
