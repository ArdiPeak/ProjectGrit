using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actButtHandler : MonoBehaviour
{
    public GameObject selectedCardObject;
    public PlayerTemplate playerData;
    public EnemyTemplate enemyData;
    public CardHandler CardHandler;

    public int playerDmg;       //player total dmg after buff and card rarity boost

    public void ConfirmCardSelection()
    {
        if (selectedCardObject != null)
        {
            DoAction(selectedCardObject);
        }
        else
        {
            Debug.LogWarning("No card selected.");
        }
    }

    private void DoAction(GameObject cardObject)
    {
        CardDisplay cardData = cardObject.GetComponent<CardDisplay>();

        if (cardData == null)
        {
            Debug.LogError("CardDisplay component not found on the selected card.");
            return;
        }
        
        // Perform action based on card type
        if (cardData.card.cardType == 1 || cardData.card.cardType == 2 || cardData.card.cardType == 3 || cardData.card.cardType == 4 )
        {
            if (playerData.playerEnergy >= cardData.card.cardCost){
                playerData.playerEnergy -= cardData.card.cardCost;
                Debug.Log("Player launches an attack with " + cardData.card.cardName);
                StartCoroutine(PerformActionWithDelay(() => PerformAttack(cardData.card.cardAtk)));
            }else{
                Debug.LogWarning("Not Enough Energy!");
            }
        }
        else if (cardData.card.cardType == 5)
        {
            playerData.playerEnergy += cardData.card.cardEnerGain;
            Debug.Log("Player heals with " + cardData.card.cardName);
            StartCoroutine(PerformActionWithDelay(() => PerformHeal(cardData.card.cardHeal)));
        }
        else if (cardData.card.cardType == 6)
        {
            if (playerData.playerEnergy >= cardData.card.cardCost){
                playerData.playerEnergy -= cardData.card.cardCost;
                Debug.Log("Player uses a buff with " + cardData.card.cardName);
                StartCoroutine(PerformActionWithDelay(() => PerformBuff(cardData.card.cardBuff)));
            }else{
                Debug.LogWarning("Not Enough Energy!");
            }
        }
        else if (cardData.card.cardType == 7)
        {
            if (playerData.playerEnergy >= cardData.card.cardCost){
                playerData.playerEnergy -= cardData.card.cardCost;
                Debug.Log("Player launches an attack with " + cardData.card.cardName);
                StartCoroutine(PerformActionWithDelay(() => PerformDebuff(cardData.card.cardAtk)));
            }else{
                Debug.LogWarning("Not Enough Energy!");
            }
        }
        else if (cardData.card.cardType == 8)
        {
            if (playerData.playerEnergy >= cardData.card.cardCost){
                playerData.playerEnergy -= cardData.card.cardCost;
                Debug.Log("Player uses a buff with " + cardData.card.cardName);
                StartCoroutine(PerformActionWithDelay(() => PerformSteal(cardData.card.cardHeal)));
            }else{
                Debug.LogWarning("Not Enough Energy!");
            }
        }
        else if (cardData.card.cardType == 9 || cardData.card.cardType == 10)
        {
            playerData.playerEnergy += cardData.card.cardEnerGain;
            Debug.Log("Player gains defends with " + cardData.card.cardName);
            StartCoroutine(PerformActionWithDelay(() => PerformDefense(cardData.card.cardDef)));
        }
    }

    private IEnumerator PerformActionWithDelay(System.Action action)
    {
        yield return new WaitForSeconds(1.0f); // Wait for 2 seconds
        action();

        // Remove the card from the handCards list
        CardHandler.handCards.Remove(selectedCardObject);
    
        // Destroy the card GameObject
        Destroy(selectedCardObject);
    }

    private void PerformAttack(int attackValue)
    {
        playerDmg += attackValue;
        enemyData.enemyHp -= playerDmg;
        playerDmg = 0;
    }

    private void PerformHeal(int healValue)
    {
        playerData.playerHp += healValue;
    }

    private void PerformBuff(int buffValue)
    {
        playerDmg += buffValue;
    }

    private void PerformDefense(int defenseValue)
    {
        playerData.playerDef += defenseValue;
    }

    private void PerformDebuff(int debuffValue)
    {
        enemyData.enemyDebuff = 3;
    }

    private void PerformSteal(int stealValue)
    {
        playerData.playerSteal = 2;
    }
}
    