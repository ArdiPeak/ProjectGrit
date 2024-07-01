using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shardCardScript : MonoBehaviour
{
    public int level = 0; //rarity C
    public int buff = 4;  //give extra 4 dmg
    public int cost = 3;
    public string cardName = "Rock Gave Me Power?";
    public string cardDesc = "Gain 4 extra damage for the next attack";
    public int cardType = 6;

    public playerScript playerData;
    
    //if the card clicked
    void OnMouseDown(){
            Debug.Log("Selected Shard");
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
