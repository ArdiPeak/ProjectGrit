using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemy", menuName = "NewEnemy")]
public class EnemyTemplate : ScriptableObject
{
    public int enemyMaxHp;
    public int enemyHp;
    public int enemyAtk;
    public int enemyDebuff;     //duration

    public Sprite enemyImg;
}
