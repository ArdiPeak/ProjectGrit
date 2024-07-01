using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punchCardScript : MonoBehaviour
{
    public int level = 0; //rarity C
    public int dmg = 4;
    public int cost = 2;
    public string cardName = "Long Jab";
    public string cardDesc = "Hit with the fist and deal 4 damage";
    public int cardType = 2;

    public playerScript playerData;
    
    //if the card clicked
    void OnMouseDown(){
            Debug.Log("Selected Punch");
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
