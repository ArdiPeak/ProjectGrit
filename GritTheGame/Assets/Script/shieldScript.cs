using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class shieldScript : MonoBehaviour
{
    public playerScript playerData;
    public turnManager dmgData;
    public TextMeshProUGUI sheildTxt;

    public int storedDmg;
    public int dmgParry;
    public bool readyParry = false;

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

        if (playerData.haveParry == true && playerData.defPlayer > 0){
            storedDmg += dmgData.damageAbsorbedByDefense;
            if (playerData.defPlayer <= 0){
                dmgParry = storedDmg;
                readyParry = true;
            }
        }

    }

    void UpdateShieldText(int totalDef)
    {
        sheildTxt.text = totalDef + " ";
    }
}
