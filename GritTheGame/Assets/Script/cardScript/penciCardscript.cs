using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penciCardscript : MonoBehaviour
{
    public int level = 0; //rarity C
    public int dmg = 2;
    public int cost = 1;
    public string cardName = "Pencils Dart";
    public string cardDesc = "Throw pencils to deal 2 damage";
    public int cardType = 1;

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