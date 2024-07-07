using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actButtHandler : MonoBehaviour
{
    public int selectedCard;

    public PlayerTemplate playerData;
    public EnemyTemplate enemyData;

    public int playerDmg;       //player total dmg after buff and card rarity boost
    //[Pencil]
    public int pencilAtk;
    public int pencilCost;
    public string pencilName;
    //[Punch]
    public int punchAtk;
    public int punchCost;
    public string punchName;
    //[Sword]
    public int swordAtk;
    public int swordCost;
    public string swordName;
    //[Pipe]
    public int pipeAtk;
    public int pipeCost;
    public string pipeName;
    //[Drink]
    public int drinkHeal;
    public int drinkGain;
    public string drinkName;
    //[Shard]
    public int shardBuff;
    public int shardCost;
    public string shardName;
    //[Poison]
    public int poisonAtk;
    public int poisonCost;
    public string poisonName;
    //[Grab]
    public int grabHeal;
    public int grabCost;
    public string grabName;
    //[Door]
    public int doorDef;
    public int doorGain;
    public string doorName;
    //[Mirror]
    public int mirrorDef;
    public int mirrorGain;
    public string mirrorName;


    public bool playerAct = false;      //when player start action

    void Start(){
        StartCoroutine(ReadCardData());
    }

    //give time card to generate before reading it
    IEnumerator ReadCardData(){
        yield return new WaitForSeconds(10);
        // Find the GameObject with the name "pencil"
        GameObject pencil = GameObject.Find("pencil");

        // Access the Card script component attached to the GameObject
        CardDisplay pencilScript = pencil.GetComponent<CardDisplay>();
        if (pencilScript != null){
            pencilAtk = pencilScript.card.cardAtk;
            pencilCost = pencilScript.card.cardCost;
            pencilName = pencilScript.card.cardName;
        }else{
            Debug.Log("Pencil not found");
        }

        // Find the GameObject with the name "punch"
        GameObject punch = GameObject.Find("punch");

        // Access the Card script component attached to the GameObject
        CardDisplay punchScript = punch.GetComponent<CardDisplay>();
        if (punchScript != null){
            punchAtk = punchScript.card.cardAtk;
            punchCost = punchScript.card.cardCost;
            punchName = punchScript.card.cardName;
        }else{
            Debug.Log("Punch not found");
        }
/*
        // Find the GameObject with the name "sword"
        GameObject sword = GameObject.Find("sword");

        // Access the Card script component attached to the GameObject
        CardDisplay swordScript = sword.GetComponent<CardDisplay>();
        if (swordScript != null){
            swordAtk = swordScript.card.cardAtk;
            swordCost = swordScript.card.cardCost;
            swordName = swordScript.card.cardName;
        }else{
            Debug.Log("Punch not found");
        }

        // Find the GameObject with the name "pipe"
        GameObject pipe = GameObject.Find("pipe");

        // Access the Card script component attached to the GameObject
        CardDisplay pipeScript = pipe.GetComponent<CardDisplay>();
        if (pipeScript != null){
            pipeAtk = pipeScript.card.cardAtk;
            pipeCost = pipeScript.card.cardCost;
            pipeName = pipeScript.card.cardName;
        }else{
            Debug.Log("Pipe not found");
        }

        // Find the GameObject with the name "drink"
        GameObject drink = GameObject.Find("drink");

        // Access the Card script component attached to the GameObject
        CardDisplay drinkScript = drink.GetComponent<CardDisplay>();
        if (drinkScript != null){
            drinkHeal = drinkScript.card.cardHeal;
            drinkGain = drinkScript.card.cardEnerGain;
            drinkName = drinkScript.card.cardName;
        }else{
            Debug.Log("Drink not found");
        }

        // Find the GameObject with the name "shard"
        GameObject shard = GameObject.Find("shard");

        // Access the Card script component attached to the GameObject
        CardDisplay shardScript = shard.GetComponent<CardDisplay>();
        if (shardScript != null){
            shardBuff = shardScript.card.cardBuff;
            shardCost = shardScript.card.cardCost;
            shardName = shardScript.card.cardName;
        }else{
            Debug.Log("Shard not found");
        }

        // Find the GameObject with the name "poison"
        GameObject poison = GameObject.Find("poison");

        // Access the Card script component attached to the GameObject
        CardDisplay poisonScript = poison.GetComponent<CardDisplay>();
        if (poisonScript != null){
            poisonAtk = poisonScript.card.cardAtk;
            poisonCost = poisonScript.card.cardCost;
            poisonName = poisonScript.card.cardName;
        }else{
            Debug.Log("Poison not found");
        }

        // Find the GameObject with the name "grab"
        GameObject grab = GameObject.Find("grab");

        // Access the Card script component attached to the GameObject
        CardDisplay grabScript = grab.GetComponent<CardDisplay>();
        if (grabScript != null){
            grabHeal = grabScript.card.cardHeal;
            grabCost = grabScript.card.cardCost;
            grabName = grabScript.card.cardName;
        }else{
            Debug.Log("Grab not found");
        }

        // Find the GameObject with the name "door"
        GameObject door = GameObject.Find("door");

        // Access the Card script component attached to the GameObject
        CardDisplay doorScript = door.GetComponent<CardDisplay>();
        if (doorScript != null){
            doorDef = doorScript.card.cardDef;
            doorGain = doorScript.card.cardEnerGain;
            doorName = doorScript.card.cardName;
        }else{
            Debug.Log("Door not found");
        }

        // Find the GameObject with the name "mirror"
        GameObject mirror = GameObject.Find("mirror");

        // Access the Card script component attached to the GameObject
        CardDisplay mirrorScript = mirror.GetComponent<CardDisplay>();
        if (mirrorScript != null){
            mirrorDef = mirrorScript.card.cardDef;
            mirrorGain = mirrorScript.card.cardEnerGain;
            mirrorName = mirrorScript.card.cardName;
        }else{
            Debug.Log("Door not found");
        }*/
    }

    public void DoAction(){
        if (selectedCard == 0){                                 //card [Empty]
            Debug.LogWarning("Please Choose A Card!");        
        }else if (selectedCard == 1){                           //act [Pencil]
            //check if player have sufficient playerEnergy
            if (playerData.playerEnergy >= pencilCost){            
                Debug.Log("Player launch " + pencilName + "!");
                playerData.playerEnergy -= pencilCost;             //deduct player playerEnergy
                playerAct = true;
                StartCoroutine(WaitForAnim());
            }else if (playerData.playerEnergy < pencilCost){
                Debug.LogWarning("Not Enough Energy!");
            }    

        }else if (selectedCard == 2){                           //act [Punch]
            //check if player have sufficient playerEnergy
            if (playerData.playerEnergy >= punchCost){            
                Debug.Log("Player launch " + punchName + "!");
                playerData.playerEnergy -= punchCost;             //deduct player playerEnergy
                playerAct = true;
                StartCoroutine(WaitForAnim());
            }else if (playerData.playerEnergy < punchCost){
                Debug.LogWarning("Not Enough Energy!");
            }    

        }else if (selectedCard == 3){                           // act [Sword]
            //check if player have sufficient playerEnergy
            if (playerData.playerEnergy >= swordCost){            
                Debug.Log("Player launch " + swordName + "!");
                playerData.playerEnergy -= swordCost;             //deduct player playerEnergy
                playerAct = true;
                StartCoroutine(WaitForAnim());
            }else if (playerData.playerEnergy < swordCost){
                Debug.LogWarning("Not Enough Energy!");
            } 
        }else if (selectedCard == 4){                           //act [Pipe]
            //check if player have sufficient playerEnergy
            if (playerData.playerEnergy >= pipeCost){            
                Debug.Log("Player launch " + pipeName + "!");
                playerData.playerEnergy -= pipeCost;             //deduct player playerEnergy
                playerAct = true;
                StartCoroutine(WaitForAnim());
            }else if (playerData.playerEnergy < pipeCost){
                Debug.LogWarning("Not Enough Energy!");
            }      
        }else if (selectedCard == 5){                           //act [Drink]        
                Debug.Log("Player launch " + drinkName + "!");
                playerData.playerEnergy += drinkGain;             //give player playerEnergy
                playerAct = true;
                StartCoroutine(WaitForAnim()); 
        }else if (selectedCard == 6){                           //act [Shard]
            //check if player have sufficient playerEnergy
            if (playerData.playerEnergy >= shardCost){            
                Debug.Log("Player launch " + shardName + "!");
                playerData.playerEnergy -= shardCost;             //deduct player playerEnergy
                playerAct = true;
                StartCoroutine(WaitForAnim());
            }else if (playerData.playerEnergy < shardCost){
                Debug.LogWarning("Not Enough Energy!");
            } 
        }else if (selectedCard == 7){                           //act [Poison]
            //check if player have sufficient playerEnergy
            if (playerData.playerEnergy >= poisonCost){            
                Debug.Log("Player launch " + poisonName + "!");
                playerData.playerEnergy -= poisonCost;             //deduct player playerEnergy
                playerAct = true;
                StartCoroutine(WaitForAnim());
            }else if (playerData.playerEnergy < poisonCost){
                Debug.LogWarning("Not Enough Energy!");
            }
        }else if (selectedCard == 8){                           //act [Grab]
            //check if player have sufficient playerEnergy
            if (playerData.playerEnergy >= grabCost){            
                Debug.Log("Player launch " + grabName + "!");
                playerData.playerEnergy -= grabCost;             //deduct player playerEnergy
                playerAct = true;
                StartCoroutine(WaitForAnim());
            }else if (playerData.playerEnergy < grabCost){
                Debug.LogWarning("Not Enough Energy!");
            }
        }else if (selectedCard == 9){                           //act [Door]
            Debug.Log("Player launch " + doorName + "!");
            playerData.playerEnergy += doorGain;             //give player playerEnergy
            playerAct = true;
            StartCoroutine(WaitForAnim());
        }else if (selectedCard == 10){                          //act [Mirror]
            Debug.Log("Player launch " + mirrorName + "!");
            playerData.playerEnergy += mirrorGain;             //give player playerEnergy
            playerAct = true;
            StartCoroutine(WaitForAnim());
        }
    }

    //delay to fit animation
    IEnumerator WaitForAnim(){
        if (selectedCard == 1 && playerAct == true){            //[Pencil]
            yield return new WaitForSeconds(1);
            playerDmg = pencilAtk;
            if (playerData.haveBuff == true){
                playerDmg += shardBuff;       //change player atk to card dmg withbuff
            }
            if (playerData.playerSteal > 0){
                playerData.playerHp += grabHeal;    
                playerData.playerSteal --;  
            }
            enemyData.enemyHp -= playerDmg;

            playerAct = false;
            playerData.haveBuff = false;
        }else if (selectedCard == 2 && playerAct == true){          //[Punch]
            yield return new WaitForSeconds(1);
            playerDmg = punchAtk;
            if (playerData.haveBuff == true){
               playerDmg += shardBuff;       //change player atk to card dmg withbuff
            }
            if (playerData.playerSteal > 0){
                playerData.playerHp += grabHeal;
                playerData.playerSteal --;
            }
            enemyData.enemyHp -= playerDmg;
            playerAct = false;
            playerData.haveBuff = false;
        }else if (selectedCard == 3 && playerAct == true){      //[Sword]
            yield return new WaitForSeconds(1);
            playerDmg = swordAtk;
            if (playerData.haveBuff == true){
               playerDmg += shardBuff;       //change player atk to card dmg withbuff
            }
            if (playerData.playerSteal > 0){
                playerData.playerHp += grabHeal;
                playerData.playerSteal --;
            }
            enemyData.enemyHp -= playerDmg;
            
            playerAct = false;
            playerData.haveBuff = false;
        }else if (selectedCard == 4 && playerAct == true){      //[Pipe]
            yield return new WaitForSeconds(1);
            playerDmg = pipeAtk;
            if (playerData.haveBuff == true){
               playerDmg += shardBuff;       //change player atk to card dmg withbuff
            }
            if (playerData.playerSteal > 0){
                playerData.playerHp += grabHeal;
                playerData.playerSteal --;
            }
            enemyData.enemyHp -= playerDmg;
            
            playerAct = false;
            playerData.haveBuff = false;
        }else if (selectedCard == 5 && playerAct == true){      //[Drink]
            yield return new WaitForSeconds(1);
            playerData.playerHp += drinkHeal;
            playerAct = false;
        }else if (selectedCard == 6 && playerAct == true){      //[Shard]
            yield return new WaitForSeconds(1);
            playerData.haveBuff = true;
            playerAct = false;
        }else if (selectedCard == 7 && playerAct == true){      //[Poison]
            yield return new WaitForSeconds(1);
            enemyData.enemyDebuff = 3;
            playerAct = false;
        }else if (selectedCard == 8 && playerAct == true){      //[Grab]
            yield return new WaitForSeconds(1);
            playerData.playerSteal = 2;
            playerAct = false;
        }else if (selectedCard == 9 && playerAct == true){      //[Door]
            yield return new WaitForSeconds(1);
            playerData.playerDef = doorDef;
            playerAct = false;
        }else if (selectedCard == 10 && playerAct == true){      //[Mirror]
            yield return new WaitForSeconds(1);
            playerData.playerDef = mirrorDef;
            playerData.haveParry = true;
            playerAct = false;
        }
    }
}
