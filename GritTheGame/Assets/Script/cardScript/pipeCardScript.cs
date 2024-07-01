using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeCardScript : MonoBehaviour
{
    public int level = 0; //rarity C
    public int dmg = 5;
    public int cost = 3;
    public string cardName = "Here's the Plumber!";
    public string cardDesc = "Hit with a metal pipe and deal 5 damage";
    public int cardType = 4;

    public playerScript playerData;
    
    //if the card clicked
    void OnMouseDown(){
            Debug.Log("Selected Pencil");
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
