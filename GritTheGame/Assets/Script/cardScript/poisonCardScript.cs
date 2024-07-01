using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poisonCardScript : MonoBehaviour
{
    public int level = 0; //rarity C
    public int dmg = 2;
    public int cost = 3;
    public string cardName = "Drinks On Me!";
    public string cardDesc = "Gave poison (DoT) effect that deal 2 damage for 3 turn";
    public int cardType = 7;

    public playerScript playerData;
    
    //if the card clicked
    void OnMouseDown(){
            Debug.Log("Selected Poison");
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
