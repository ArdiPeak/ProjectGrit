using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confirmAct : MonoBehaviour
{
    public playerScript playerData;
    public enemyTScript teachData;
    public turnManager turnManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
      
    }

    //if the confirm button clicked
    void OnMouseDown(){
            if (playerData.selectedCard != 0 && turnManager.playerTurn == true){  //run action if player turn and card selected 
                Debug.Log("Action Confirmed");
                teachData.hpOpp -= playerData.atkPlayer;  //will changed base on card
                turnManager.playerTurn = false;
                playerData.selectedCard = 0;
            }else if(playerData.selectedCard == 0 && turnManager.playerTurn == true){ //ask to select card if no card selected 
                 Debug.Log("Please Select a Card");
            }
    }  
}
