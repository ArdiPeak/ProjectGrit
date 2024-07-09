using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthOppScript : MonoBehaviour
{
    public EnemyTemplate enemyData;
    public Slider slider;
    public TextMeshProUGUI hptxt;

    // Start is called before the first frame update
    void Start()
    {
        enemyData.enemyHp = enemyData.enemyMaxHp;
        slider.maxValue = enemyData.enemyMaxHp;   //match bar max value with player max hp
        slider.value = enemyData.enemyHp;  //match bar vlaue with player value
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = enemyData.enemyHp;
        int maxHealth = enemyData.enemyMaxHp;
        int currentHealth = enemyData.enemyHp;
        UpdateHealthText(currentHealth,maxHealth);
        if (enemyData.enemyHp < 0){
            enemyData.enemyHp = 0;
        }
    }

    void UpdateHealthText(int currentHealth, int maxHealth)
    {
        hptxt.text = currentHealth + " / " + maxHealth;
    }
}
