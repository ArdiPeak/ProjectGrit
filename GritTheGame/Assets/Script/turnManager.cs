using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnManager : MonoBehaviour
{
    public bool playerTurn; //player turn first start
    public playerScript playerData;
    public enemyTScript teachData;

    // Start is called before the first frame update
    void Start(){
        playerTurn = true;
    }

    // Update is called once per frame
    void Update(){
        if (playerTurn != true){
            playerData.hpPlayer -= teachData.atkOpp;  //enemy atk player
            Debug.Log("Enemy atk!");
            playerTurn = true;
        }
    }
}
