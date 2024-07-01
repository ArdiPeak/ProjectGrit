using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordCardScript : MonoBehaviour
{
    public int level = 0; //rarity C
    public int dmg = 7;
    public int cost = 4;
    public string cardName = "Keeper Cut";
    public string cardDesc = "Slash a sword an deal 7 damage";
    public int cardType = 3;

    public playerScript playerData;
    
    //if the card clicked
    void OnMouseDown(){
            Debug.Log("Selected Sword");
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
