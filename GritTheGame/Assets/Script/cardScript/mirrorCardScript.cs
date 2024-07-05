using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirrorCardScript : MonoBehaviour
{
    public int level = 0; //rarity C
    public int block = 6;
    public int cost = 6;  //cost gained
    public string cardName = "Return To The Owner!";
    public string cardDesc = "Gain 6 Shield and deal the same damage received from enemy.";
    public int cardType = 10;

    public playerScript playerData;
    
    //if the card clicked
    void OnMouseDown(){
            Debug.Log("Selected Mirror");
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
