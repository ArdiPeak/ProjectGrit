using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnManager : MonoBehaviour
{
    public bool playerTurn; //player turn first start
    public playerScript playerData;
    public enemyTScript teachData;
    public poisonCardScript poisonAction;

    public int dmgReceive;

    // Start is called before the first frame update
    void Start(){
        playerTurn = true;
    }

    // Update is called once per frame
    void Update(){
        if (playerTurn != true){
            // Deal Dot to enemy
            if (teachData.haveDebuff >0){
                teachData.hpOpp -= poisonAction.dmg;
                teachData.haveDebuff --;
            }
            
            dmgReceive = teachData.atkOpp;      

            // Reduce defense first
            if (playerData.defPlayer > 0)
            {
                int damageAbsorbedByDefense = Mathf.Min(playerData.defPlayer, dmgReceive);
                playerData.defPlayer -= damageAbsorbedByDefense;
                dmgReceive -= damageAbsorbedByDefense;
            }

            // Apply any remaining damage to HP
            if (dmgReceive > 0)
            {
                playerData.hpPlayer -= dmgReceive;
            }
            Debug.Log("Enemy atk!");
            playerTurn = true;
        }
    }
}
