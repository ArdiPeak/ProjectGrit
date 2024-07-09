using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class shieldScript : MonoBehaviour
{
    public PlayerTemplate playerData;
    public TextMeshProUGUI sheildTxt;

    // Start is called before the first frame update
    void Start()
    {
        playerData.playerDef = 0;
    }

    // Update is called once per frame
    void Update()
    {
        int totalDef = playerData.playerDef;
        UpdateShieldText(totalDef);
    }

    void UpdateShieldText(int totalDef)
    {
        sheildTxt.text = totalDef.ToString();
    }

   

}
