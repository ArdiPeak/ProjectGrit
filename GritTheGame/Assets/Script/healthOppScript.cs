using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthOppScript : MonoBehaviour
{
    public enemyTScript teachData;
    public Slider slider;
    public TextMeshProUGUI hptxt;

    // Start is called before the first frame update
    void Start()
    {
        teachData.hpOpp = teachData.maxhpOpp;
        slider.maxValue = teachData.maxhpOpp;   //match bar max value with player max hp
        slider.value = teachData.hpOpp;  //match bar vlaue with player value
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = teachData.hpOpp;
        int maxHealth = teachData.maxhpOpp;
        int currentHealth = teachData.hpOpp;
        UpdateHealthText(currentHealth,maxHealth);
        if (teachData.hpOpp < 0){
            teachData.hpOpp = 0;
        }
    }

    void UpdateHealthText(int currentHealth, int maxHealth)
    {
        hptxt.text = currentHealth + " / " + maxHealth;
    }
}
