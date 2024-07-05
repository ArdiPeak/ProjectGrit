using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "New Card")]
public class CardTemplate : ScriptableObject
{
    public int cardAtk;
    public int cardHeal;
    public int cardBuff;    
    public int cardDef;
    public int cardCost;
    public int cardEnerGain;
    public int cardType;

    public string cardName;
    public string cardDesc;
    public char cardRare;

    public Sprite cardImg;
}
