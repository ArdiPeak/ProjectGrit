using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confirmAct : MonoBehaviour
{
    public playerScript playerData;
    public enemyTScript teachData;
    public turnManager turnManager;

    public penciCardscript pencilAction;            //list of all card
    public punchCardScript punchAction;
    public swordCardScript swordAction;
    public pipeCardScript pipeAction;
    public drinkCardScript drinkAction;
    public shardCardScript shardAction;
    public poisonCardScript poisonAction;
    public grabCardScript grabAction;
    public doorCardScript doorAction;
    public mirrorCardScript mirrorAction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
      
    }

    //if the confirm button clicked
    void OnMouseDown(){
        turnManager.doneAtk = false;
            if (playerData.selectedCard == 1 && turnManager.playerTurn == true){  //run action [Pencil]
                if (playerData.energy >= pencilAction.cost){            //check if player have suffivient energy
                    Debug.Log(pencilAction.cardName);
                    playerData.energy -= pencilAction.cost;             //deduct player energy

                    if (playerData.haveBuff == true){
                        playerData.atkPlayer = pencilAction.dmg + shardAction.buff;        //change player atk to card dmg withbuff
                    }else{
                        playerData.atkPlayer = pencilAction.dmg;            //change player atk to card dmg
                    }
                    if (playerData.haveSteal > 0){
                        teachData.hpOpp -= playerData.atkPlayer;            //deal damage to enemy
                        playerData.hpPlayer += grabAction.steal;             //steal some hp
                        playerData.haveSteal --;
                    }else{
                        teachData.hpOpp -= playerData.atkPlayer;
                    }
                    
                    playerData.atkPlayer = 0;                           //reset player atk
                    playerData.haveBuff = false;                         //remove buff to player
                    turnManager.playerTurn = false;                     //make turn for enemy after this
                    playerData.selectedCard = 0;                        //reset selected card
                }else if (playerData.energy < pencilAction.cost){
                     Debug.LogWarning("Not Enough Energy!");
                }

            }else if (playerData.selectedCard == 2 && turnManager.playerTurn == true){  //run action [Punch]
                if (playerData.energy >= punchAction.cost){            //check if player have suffivient energy
                    Debug.Log(punchAction.cardName);
                    playerData.energy -= punchAction.cost;             //deduct player energy

                    if (playerData.haveBuff == true){
                        playerData.atkPlayer = punchAction.dmg + shardAction.buff;        //change player atk to card dmg withbuff
                    }else{
                        playerData.atkPlayer = punchAction.dmg;            //change player atk to card dmg
                    }
                    if (playerData.haveSteal > 0){
                        teachData.hpOpp -= playerData.atkPlayer;            //deal damage to enemy
                        playerData.hpPlayer += grabAction.steal;             //steal some hp
                        playerData.haveSteal --;
                    }else{
                        teachData.hpOpp -= playerData.atkPlayer;
                    }

                    playerData.atkPlayer = 0;                           //reset player atk
                    playerData.haveBuff = false;                         //remove buff to player
                    turnManager.playerTurn = false;                     //make turn for enemy after this
                    playerData.selectedCard = 0;                        //reset selected card
                }else if (playerData.energy < punchAction.cost){
                     Debug.LogWarning("Not Enough Energy!");
                }

            }else if (playerData.selectedCard == 3 && turnManager.playerTurn == true){  //run action [Sword]
                if (playerData.energy >= swordAction.cost){            //check if player have suffivient energy
                    Debug.Log(swordAction.cardName);
                    playerData.energy -= swordAction.cost;             //deduct player energy

                    if (playerData.haveBuff == true){
                        playerData.atkPlayer = swordAction.dmg + shardAction.buff;        //change player atk to card dmg withbuff
                    }else{
                        playerData.atkPlayer = swordAction.dmg;            //change player atk to card dmg
                    }
                    if (playerData.haveSteal > 0){
                        teachData.hpOpp -= playerData.atkPlayer;            //deal damage to enemy
                        playerData.hpPlayer += grabAction.steal;             //steal some hp
                        playerData.haveSteal --;
                    }else{
                        teachData.hpOpp -= playerData.atkPlayer;
                    }
                  
                    playerData.atkPlayer = 0;                           //reset player atk
                    playerData.haveBuff = false;                         //remove buff to player
                    turnManager.playerTurn = false;                     //make turn for enemy after this
                    playerData.selectedCard = 0;                        //reset selected card
                }else if (playerData.energy < swordAction.cost){
                     Debug.LogWarning("Not Enough Energy!");
                }

            }else if (playerData.selectedCard == 4 && turnManager.playerTurn == true){  //run action [Pipe]
                if (playerData.energy >= pipeAction.cost){            //check if player have suffivient energy
                    Debug.Log(pipeAction.cardName);
                    playerData.energy -= pipeAction.cost;             //deduct player energy

                    if (playerData.haveBuff == true){
                        playerData.atkPlayer = pipeAction.dmg + shardAction.buff;        //change player atk to card dmg withbuff
                    }else{
                        playerData.atkPlayer = pipeAction.dmg;            //change player atk to card dmg
                    }
                    if (playerData.haveSteal > 0){
                        teachData.hpOpp -= playerData.atkPlayer;            //deal damage to enemy
                        playerData.hpPlayer += grabAction.steal;             //steal some hp
                        playerData.haveSteal --;
                    }else{
                        teachData.hpOpp -= playerData.atkPlayer;
                    }
                   
                    playerData.atkPlayer = 0;                           //reset player atk
                    playerData.haveBuff = false;                         //remove buff to player
                    turnManager.playerTurn = false;                     //make turn for enemy after this
                    playerData.selectedCard = 0;                        //reset selected card
                }else if (playerData.energy < pipeAction.cost){
                     Debug.LogWarning("Not Enough Energy!");
                }

            }else if (playerData.selectedCard == 5 && turnManager.playerTurn == true){  //run action [Drink]
                if (playerData.energy >= drinkAction.cost){            //check if player have suffivient energy
                    Debug.Log(drinkAction.cardName);
                    playerData.energy += drinkAction.cost;             //give player energy
                    playerData.hpPlayer += drinkAction.heal;             //heal player
                    playerData.atkPlayer = 0;                           //reset player atk
                    turnManager.playerTurn = false;                     //make turn for enemy after this
                    playerData.selectedCard = 0;                        //reset selected card
                }else if (playerData.energy < drinkAction.cost){
                     Debug.LogWarning("Not Enough Energy!");
                }

            }else if (playerData.selectedCard == 6 && turnManager.playerTurn == true){  //run action [Shard]
                if (playerData.energy >= shardAction.cost){            //check if player have suffivient energy
                    Debug.Log(shardAction.cardName);
                    playerData.energy -= shardAction.cost;             //deduct player energy
                    playerData.haveBuff = true;                         //give buff to player
                    playerData.atkPlayer = 0;                           //reset player atk
                    turnManager.playerTurn = false;                     //make turn for enemy after this
                    playerData.selectedCard = 0;                        //reset selected card
                }else if (playerData.energy < shardAction.cost){
                     Debug.LogWarning("Not Enough Energy!");
                }

            }else if (playerData.selectedCard == 7 && turnManager.playerTurn == true){  //run action [Poison]
                if (playerData.energy >= poisonAction.cost){            //check if player have suffivient energy
                    Debug.Log(poisonAction.cardName);
                    playerData.energy -= poisonAction.cost;             //deduct player energy
                    teachData.haveDebuff = 3;                        //give 3 turn debuff to enemy
                    playerData.atkPlayer = 0;                           //reset player atk
                    turnManager.playerTurn = false;                     //make turn for enemy after this
                    playerData.selectedCard = 0;                        //reset selected card
                }else if (playerData.energy < poisonAction.cost){
                     Debug.LogWarning("Not Enough Energy!");
                }
                
            }else if (playerData.selectedCard == 8 && turnManager.playerTurn == true){  //run action [Grab]
                if (playerData.energy >= grabAction.cost){            //check if player have suffivient energy
                    Debug.Log(grabAction.cardName);
                    playerData.energy -= grabAction.cost;             //deduct player energy
                    playerData.haveSteal = 2;                        //give 2 turn of life steal to player
                    playerData.atkPlayer = 0;                           //reset player atk
                    turnManager.playerTurn = false;                     //make turn for enemy after this
                    playerData.selectedCard = 0;                        //reset selected card
                }else if (playerData.energy < grabAction.cost){
                     Debug.LogWarning("Not Enough Energy!");
                }
                
            }else if (playerData.selectedCard == 9 && turnManager.playerTurn == true){  //run action [Door]
                    Debug.Log(doorAction.cardName);
                    playerData.energy += doorAction.cost;             //give player energy
                    playerData.defPlayer += doorAction.block;            //add shield
                    playerData.atkPlayer = 0;                           //reset player atk
                    turnManager.playerTurn = false;                     //make turn for enemy after this
                    playerData.selectedCard = 0;                        //reset selected card
                
            }else if (playerData.selectedCard == 10 && turnManager.playerTurn == true){  //run action [Mirror]
                    Debug.Log(mirrorAction.cardName);
                    playerData.energy += mirrorAction.cost;             //give player energy
                    playerData.defPlayer += mirrorAction.block;           //add shield
                    playerData.haveParry = true;
                    playerData.atkPlayer = 0;                           //reset player atk
                    turnManager.playerTurn = false;                     //make turn for enemy after this
                    playerData.selectedCard = 0;                        //reset selected card
                
            }else if(playerData.selectedCard == 0 && turnManager.playerTurn == true){ //ask to select card if no card selected 
                 Debug.LogWarning("Please Select a Card");
            }
    }  
}
