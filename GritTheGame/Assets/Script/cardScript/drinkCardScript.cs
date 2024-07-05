using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drinkCardScript : MonoBehaviour
{
    public int level = 0; //rarity C
    public int heal = 5;
    public int cost = 3;
    public string cardName = "Take 5 Please!";
    public string cardDesc = "Drink to heal 5 HP";
    public int cardType = 5;

    public playerScript playerData;
    
    //if the card clicked
    void OnMouseDown(){
            Debug.Log("Selected Drink");
            playerData.selectedCard = cardType;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
