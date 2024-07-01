using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabCardScript : MonoBehaviour
{
    public int level = 0; //rarity C
    public int steal = 3;   //lifesteal
    public int cost = 4;
    public string cardName = "I Need It!";
    public string cardDesc = "Gain Life Steal buff, every time attack, heal 3 HP for 2 turns";
    public int cardType = 8;

    public playerScript playerData;
    
    //if the card clicked
    void OnMouseDown(){
            Debug.Log("Selected Grab");
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
