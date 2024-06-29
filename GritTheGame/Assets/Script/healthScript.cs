using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthScript : MonoBehaviour
{
    public playerScript playerData;
    public Slider slider;

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
    }
}
