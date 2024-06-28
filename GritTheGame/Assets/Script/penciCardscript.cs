using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penciCardscript : MonoBehaviour
{
    public int level = 0; //rarity C
    public int dmg = 3;
    public int cost = 1;
    public string cardName = "Pencils Throw";
    public string cardDesc = "Yeet the pencils";
    public char cardCode = 'P';

    public playerScript playerData;
    
    //if the card clicked
    void OnMouseDown(){
            Debug.Log("Selected Pencil");
            playerData.selectedCard = cardCode;
            playerData.atkPlayer = dmg;
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
