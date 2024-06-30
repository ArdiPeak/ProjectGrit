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
        // Generate more cards as needed
    }

    void Update(){
        if (Input.anyKeyDown){
            GenerateRandomCard();  //generate card when recieve input
        }
    }

    void InitializeCards()
    {
        // Initialize allCards list with all possible cards
        allCards = new List<Card>
        {
            new Card("pencil", 1),
            new Card("punch", 2),
            new Card("sword", 3),
            new Card("pipe", 4),
            new Card("drink", 5),
            new Card("shard", 6),
            new Card("poison", 7),
            new Card("grab", 8),
            new Card("door", 9),
            new Card("mirror", 10),
            // Add all your cards here
        };

        // Initialize availableCards with allCards initially
        availableCards = new List<Card>(allCards);
        generatedCards = new List<Card>();
    }

    void GenerateRandomCard()
    {
        if (availableCards.Count == 0)
        {
            Debug.LogWarning("No more unique cards to generate!");
            return;
        }

        // Get a random index
        int randomIndex = Random.Range(0, availableCards.Count);

        // Select the card at the random index
        Card selectedCard = availableCards[randomIndex];

        // Remove the selected card from availableCards and add it to generatedCards
        availableCards.RemoveAt(randomIndex);
        generatedCards.Add(selectedCard);

        Debug.Log("Generated Card: " + selectedCard.name + " with value " + selectedCard.value);
    }
}

