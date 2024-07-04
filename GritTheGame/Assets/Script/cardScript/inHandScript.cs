using UnityEngine;
using System.Collections.Generic;

public class inHandScript : MonoBehaviour
{
    // Define the positions of the hand slots
    public Vector2[] handSlotPos = new Vector2[3];
    // Reference to the CardGenerator script
    public CardGenerator cardGenerator;

    // A list to hold the cards currently in hand
    public List<GameObject> handCards = new List<GameObject>();

    void Start()
    {
        // Initialize hand slot positions (you can set these to whatever you need)
        handSlotPos[0] = new Vector2(-21, -10);
        handSlotPos[1] = new Vector2(-13, -10);
        handSlotPos[2] = new Vector2(-5, -10);

        // Call the method to check slots and fill empty ones
        CheckAndFillHandSlots();
    }

    void Update()
    {
        // Continuously check and fill empty hand slots
        CheckAndFillHandSlots();
    }

    void CheckAndFillHandSlots()
    {
        for (int i = 0; i < handSlotPos.Length; i++)
        {
            bool slotFilled = false;

            foreach (GameObject card in handCards)
            {
                if ((Vector2)card.transform.position == handSlotPos[i])
                {
                    slotFilled = true;
                    break;
                }
            }

            if (!slotFilled)
            {
                GenerateRandomCard(handSlotPos[i]);
            }
        }
    }

    void GenerateRandomCard(Vector2 slotPosition)
    {
        // Generate a random card and add it to the handCards list
        GameObject newCard = cardGenerator.GenerateRandomCard(slotPosition);
        if (newCard != null)
        {
            handCards.Add(newCard);
        }
    }

    public void MoveCardToHand(GameObject card, Vector2 slotPosition)
    {
        // Move the card to the specified slot position
        card.transform.position = slotPosition;

        // Add the card to the handCards list if not already present
        if (!handCards.Contains(card))
        {
            handCards.Add(card);
        }
    }
}
