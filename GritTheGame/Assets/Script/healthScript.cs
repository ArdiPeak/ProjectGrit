using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthScript : MonoBehaviour
{
    public playerScript playerData;
    public Slider slider;
    public TextMeshProUGUI hptxt;

    // Start is called before the first frame update
    void Start()
    {
        playerData.hpPlayer = playerData.maxHpPlayer;
        slider.maxValue = playerData.maxHpPlayer;   //match bar max value with player max hp
        slider.value = playerData.hpPlayer;  //match bar vlaue with player value
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = playerData.hpPlayer;
        int maxHealth = playerData.maxHpPlayer;
        int currentHealth = playerData.hpPlayer;
        UpdateHealthText(currentHealth,maxHealth);
        if (playerData.hpPlayer < 0){
            playerData.hpPlayer = 0;        //set the min hp to 0
        }
    }

    void UpdateHealthText(int currentHealth, int maxHealth)
    {
        hptxt.text = currentHealth + " / " + maxHealth;
    }
}
