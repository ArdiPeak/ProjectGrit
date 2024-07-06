using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InHandScript : MonoBehaviour
{
    // Define the positions of the hand slots
    public Vector3[] handSlotPos = new Vector3[3];
    // Reference to the CardGenerator script
    public CardGenerator cardGenerator;

    // A list to hold the cards currently in hand
    public List<GameObject> handCards = new List<GameObject>();

    // Parent transform for hand slots in the hierarchy
    public Transform handSlotsParent;

    void Start()
    {
        // Ensure handSlotsParent is assigned
        if (handSlotsParent == null)
        {
            Debug.LogError("handSlotsParent is not assigned in the inspector.");
            return;
        }

        // Initialize hand slot positions (you can set these to whatever you need)

        handSlotPos[0] = new Vector3(-27, -5, 0);
        handSlotPos[1] = new Vector3(-19, -5, 0);
        handSlotPos[2] = new Vector3(-11, -5, 0);

        // Convert handSlotPos to canvas space if necessary
        for (int i = 0; i < handSlotPos.Length; i++)
        {
            handSlotPos[i] = ConvertWorldToCanvasPosition(handSlotPos[i]);
        }

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
                if (Vector3.Distance((Vector2)card.transform.localPosition, handSlotPos[i]) < 1f)
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

    void GenerateRandomCard(Vector3 slotPosition)
    {
        // Generate a random card and add it to the handCards list
        GameObject newCard = cardGenerator.GenerateRandomCard(slotPosition, handSlotsParent);
        if (newCard != null)
        {
            handCards.Add(newCard);
        }
    }

    public void MoveCardToHand(GameObject card, Vector3 slotPosition)
    {
        // Move the card to the specified slot position
        card.transform.localPosition = slotPosition;

        // Add the card to the handCards list if not already present
        if (!handCards.Contains(card))
        {
            handCards.Add(card);
        }
    }

    Vector3 ConvertWorldToCanvasPosition(Vector3 worldPosition)
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(worldPosition);
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            handSlotsParent as RectTransform, screenPoint, Camera.main, out Vector2 canvasPos);
        return canvasPos;
    }
}
