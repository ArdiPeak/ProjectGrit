using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorCardScript : MonoBehaviour
{
    public int level = 0; //rarity C
    public int block = 5;
    public int cost = 4;  //gain 4 cost
    public string cardName = "Knock! Knock!";
    public string cardDesc = "Hold a door and gain 5 shield";
    public int cardType = 9;

    public playerScript playerData;
    
    //if the card clicked
    void OnMouseDown(){
            Debug.Log("Selected Door");
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
