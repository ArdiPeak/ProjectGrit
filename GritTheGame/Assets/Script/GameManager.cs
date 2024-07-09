using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerTemplate playerData;
    public EnemyTemplate enemyData;

    public void CheckWin(){
        if (enemyData.enemyHp < 0){
            Debug.Log("YOU WIN!");
        }
    }

    public void CheckLose(){
        if (playerData.playerHp < 0){
            Debug.Log("YOU LOSE!");
        }
    }
}
