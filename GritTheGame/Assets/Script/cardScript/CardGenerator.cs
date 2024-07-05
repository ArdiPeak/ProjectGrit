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
            new Card("pencil", 1, Resources.Load<GameObject>("Prefabs/pencilCard")),
            new Card("punch", 2, Resources.Load<GameObject>("Prefabs/punchCard")),
            new Card("sword", 3, Resources.Load<GameObject>("Prefabs/swordCard")),
            new Card("pipe", 4, Resources.Load<GameObject>("Prefabs/pipeCard")),
            new Card("drink", 5, Resources.Load<GameObject>("Prefabs/drinkCard")),
            new Card("shard", 6, Resources.Load<GameObject>("Prefabs/shardCard")),
            new Card("poison", 7, Resources.Load<GameObject>("Prefabs/poisonCard")),
            new Card("grab", 8, Resources.Load<GameObject>("Prefabs/grabCard")),
            new Card("door", 9, Resources.Load<GameObject>("Prefabs/doorCard")),
            new Card("mirror", 10, Resources.Load<GameObject>("Prefabs/mirrorCard")),
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

    public GameObject GenerateRandomCard(Vector2 position)
    {
        if (availableCards.Count == 0)
        {
            Debug.LogWarning("No more unique cards to generate!");
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

        // Instantiate the card GameObject at the given position using the card's specific prefab
        GameObject newCard = Instantiate(selectedCard.prefab, position, Quaternion.identity);
        newCard.name = selectedCard.name; // Assign a name to the GameObject for easier identification

        Debug.Log("Generated Card: " + selectedCard.name + " with value " + selectedCard.value);
        return newCard;
    }
}
