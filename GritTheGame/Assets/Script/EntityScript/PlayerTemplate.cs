using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayer", menuName = "NewPlayer")]
public class PlayerTemplate : ScriptableObject
{
    public int playerMaxHp;
    public int playerHp;
    public int playerDef;    
    public int playerEnergy;
    public int playerSteal;      //duration
    public bool haveBuff = false;
    public bool haveParry = false;

    public Sprite playerImg;
}
