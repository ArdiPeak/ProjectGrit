using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
   public CardTemplate card;
   
   public SpriteRenderer cardSprite;
   public TextMeshProUGUI attribText;
   public TextMeshProUGUI costText;
   public TextMeshProUGUI rareText;
   public TextMeshProUGUI valueText;

   Color newColor1;
   Color newColor2;
   Color newColor3;
   Color newColor4;
   Color newColor5;
   Color newColor6;
   Color newColor7;
   Color newColor8;
   
    void Start(){
        cardSprite.sprite = card.cardImg;   //display sprite
        
        //display enery cost and gain
        if (card.cardCost > 0){
            costText.text = card.cardCost.ToString();
            ColorUtility.TryParseHtmlString("#EF5350", out newColor5);       //red
            costText.color = newColor5;
        }else if (card.cardEnerGain > 0){
            costText.text = card.cardEnerGain.ToString();
            ColorUtility.TryParseHtmlString("#4CAF50", out newColor6);      //green
            costText.color = newColor6;
        }
        
        //display type of atribute
        if (card.cardAtk > 0){
            attribText.text = "Atk";
        }else if (card.cardHeal > 0){
            attribText.text = "+Hp";
        }else if (card.cardBuff > 0){
            attribText.text = "+Atk";
        }else if (card.cardDef > 0){
            attribText.text = "Def";
        }

        //display rarity w/ color
        rareText.text = card.cardRare.ToString();

        if (card.cardRare == 'C'){
            if (ColorUtility.TryParseHtmlString("#757575", out newColor1)){       //gray
                rareText.color = newColor1; 
            }else{
                Debug.LogError("Invalid hex color string.");
            }   
        }else if (card.cardRare == 'B'){
            if (ColorUtility.TryParseHtmlString("#43A047", out newColor2)){       //green
                rareText.color = newColor2; 
            }else{
                Debug.LogError("Invalid hex color string.");
            }  
        }else if (card.cardRare == 'A'){
            if (ColorUtility.TryParseHtmlString("#8E24AA", out newColor3)){       //purple
                rareText.color = newColor3; 
            }else{
                Debug.LogError("Invalid hex color string.");
            }
        }else if (card.cardRare == 'S'){
            if (ColorUtility.TryParseHtmlString("#FF9800", out newColor4)){       //gold
                rareText.color = newColor4; 
            }else{
                Debug.LogError("Invalid hex color string.");
            }
        }

        //display attribute value w/ color
        if (card.cardAtk > 0){
            valueText.text = card.cardAtk.ToString();
            ColorUtility.TryParseHtmlString("#EF5350", out newColor5);       //red
            valueText.color = newColor5;
        }else if (card.cardHeal > 0){
            valueText.text = card.cardHeal.ToString();
            ColorUtility.TryParseHtmlString("#4CAF50", out newColor6);      //green
            valueText.color = newColor6;
        }else if (card.cardBuff > 0){
            valueText.text = card.cardBuff.ToString();
            ColorUtility.TryParseHtmlString("#FFEB3B", out newColor7);      //yellow
            valueText.color = newColor7;
        }else if (card.cardDef > 0){
            valueText.text = card.cardDef.ToString();
            ColorUtility.TryParseHtmlString("#2196F3", out newColor8);      //blue
            valueText.color = newColor8;
        }
    }
}

