using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthScript : MonoBehaviour
{
    public PlayerTemplate playerData;
    public Slider slider;
    public TextMeshProUGUI hptxt;

    // Start is called before the first frame update
    void Start()
    {
        playerData.playerHp = playerData.playerMaxHp;
        slider.maxValue = playerData.playerMaxHp;   //match bar max value with player max hp
        slider.value = playerData.playerHp;  //match bar vlaue with player value
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = playerData.playerHp;

        int maxHealth = playerData.playerMaxHp;
        int currentHealth = playerData.playerHp;

        UpdateHealthText(currentHealth,maxHealth);
        if (playerData.playerHp < 0){
            playerData.playerHp = 0;        //set the min hp to 0
        }
        if (playerData.playerHp > playerData.playerMaxHp){
            playerData.playerHp = playerData.playerMaxHp;        //set the min hp to 0
        }
    }

    void UpdateHealthText(int currentHealth, int maxHealth)
    {
        hptxt.text = currentHealth + " / " + maxHealth;
    }
}
