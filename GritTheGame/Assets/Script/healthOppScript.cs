using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthOppScript : MonoBehaviour
{
    public enemyTScript teachData;
    public Slider slider;

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
    }
}
