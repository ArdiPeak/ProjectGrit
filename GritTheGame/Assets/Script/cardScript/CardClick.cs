using UnityEngine;
using UnityEngine.EventSystems;

public class CardClick : MonoBehaviour
{
    public CardTemplate cardData;
    public actButtHandler actionButton;

    void Start(){
        actionButton = GameObject.Find("ActionHandler").GetComponent<actButtHandler>();
        //to assign automaticlly
    }

    public void OnMouseDown()
    {
        actionButton.selectedCardObject = gameObject;  // Store the reference to the clicked card
        Debug.Log("Selected Card: " + gameObject);
    }
}
