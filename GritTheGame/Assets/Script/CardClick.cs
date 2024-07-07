using UnityEngine;
using UnityEngine.EventSystems;

public class CardClick : MonoBehaviour
{
    public CardTemplate cardData;
    public actButtHandler actionButton;

    void Start(){
        actionButton = GameObject.Find("GameManager").GetComponent<actButtHandler>();
        //to assign automaticlly
    }

    public void OnMouseDown()
    {
        Debug.Log("Card Clicked! " + cardData.cardType);
        actionButton.selectedCard = cardData.cardType;
        Debug.Log("Selected Card: " + actionButton.selectedCard);
    }
}
