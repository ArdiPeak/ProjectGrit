using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class shieldScript : MonoBehaviour
{
    public playerScript playerData;
    public enemyTScript teachData;
    public turnManager dmgData;
    public TextMeshProUGUI sheildTxt;

    // Start is called before the first frame update
    void Start()
    {
        playerData.defPlayer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        int totalDef = playerData.defPlayer;
        UpdateShieldText(totalDef);
    }

    void UpdateShieldText(int totalDef)
    {
        sheildTxt.text = totalDef + " ";
    }

   

}
