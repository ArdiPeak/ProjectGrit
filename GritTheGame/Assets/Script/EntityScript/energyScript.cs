using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class energyScript : MonoBehaviour
{
    public PlayerTemplate playerData;

    public GameObject eneBar1;
    public GameObject eneBar2;
    public GameObject eneBar3;
    public GameObject eneBar4;
    public GameObject eneBar5;
    public GameObject eneBar6;
    public GameObject eneBar7;
    public GameObject eneBar8;
    public GameObject eneBar9;
    public GameObject eneBar10;

    public TextMeshProUGUI enertxt;

    // Start is called before the first frame update
    void Start()
    {
        playerData.playerEnergy = 10;
        eneBar1.SetActive(true);
        eneBar2.SetActive(true);
        eneBar3.SetActive(true);
        eneBar4.SetActive(true);
        eneBar5.SetActive(true);
        eneBar6.SetActive(true);
        eneBar7.SetActive(true);
        eneBar8.SetActive(true);
        eneBar9.SetActive(true);
        eneBar10.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerData.playerEnergy > 10){
            playerData.playerEnergy = 10;
        }

        int storedEner = playerData.playerEnergy; 
        UpdateEnergyText(storedEner);

        if (playerData.playerEnergy == 0){
            eneBar1.SetActive(false);
            eneBar2.SetActive(false);
            eneBar3.SetActive(false);
            eneBar4.SetActive(false);
            eneBar5.SetActive(false);
            eneBar6.SetActive(false);
            eneBar7.SetActive(false);
            eneBar8.SetActive(false);
            eneBar9.SetActive(false);
            eneBar10.SetActive(false);
        }else if (playerData.playerEnergy == 1){
            eneBar1.SetActive(true);
            eneBar2.SetActive(false);
            eneBar3.SetActive(false);
            eneBar4.SetActive(false);
            eneBar5.SetActive(false);
            eneBar6.SetActive(false);
            eneBar7.SetActive(false);
            eneBar8.SetActive(false);
            eneBar9.SetActive(false);
            eneBar10.SetActive(false);
        }else if (playerData.playerEnergy == 2){
            eneBar1.SetActive(true);
            eneBar2.SetActive(true);
            eneBar3.SetActive(false);
            eneBar4.SetActive(false);
            eneBar5.SetActive(false);
            eneBar6.SetActive(false);
            eneBar7.SetActive(false);
            eneBar8.SetActive(false);
            eneBar9.SetActive(false);
            eneBar10.SetActive(false);
        }else if (playerData.playerEnergy == 3){
            eneBar1.SetActive(true);
            eneBar2.SetActive(true);
            eneBar3.SetActive(true);
            eneBar4.SetActive(false);
            eneBar5.SetActive(false);
            eneBar6.SetActive(false);
            eneBar7.SetActive(false);
            eneBar8.SetActive(false);
            eneBar9.SetActive(false);
            eneBar10.SetActive(false);
        }else if (playerData.playerEnergy == 4){
            eneBar1.SetActive(true);
            eneBar2.SetActive(true);
            eneBar3.SetActive(true);
            eneBar4.SetActive(true);
            eneBar5.SetActive(false);
            eneBar6.SetActive(false);
            eneBar7.SetActive(false);
            eneBar8.SetActive(false);
            eneBar9.SetActive(false);
            eneBar10.SetActive(false);
        }else if (playerData.playerEnergy == 5){
            eneBar1.SetActive(true);
            eneBar2.SetActive(true);
            eneBar3.SetActive(true);
            eneBar4.SetActive(true);
            eneBar5.SetActive(true);
            eneBar6.SetActive(false);
            eneBar7.SetActive(false);
            eneBar8.SetActive(false);
            eneBar9.SetActive(false);
            eneBar10.SetActive(false);
        }else if (playerData.playerEnergy == 6){
            eneBar1.SetActive(true);
            eneBar2.SetActive(true);
            eneBar3.SetActive(true);
            eneBar4.SetActive(true);
            eneBar5.SetActive(true);
            eneBar6.SetActive(true);
            eneBar7.SetActive(false);
            eneBar8.SetActive(false);
            eneBar9.SetActive(false);
            eneBar10.SetActive(false);
        }else if (playerData.playerEnergy == 7){
            eneBar1.SetActive(true);
            eneBar2.SetActive(true);
            eneBar3.SetActive(true);
            eneBar4.SetActive(true);
            eneBar5.SetActive(true);
            eneBar6.SetActive(true);
            eneBar7.SetActive(true);
            eneBar8.SetActive(false);
            eneBar9.SetActive(false);
            eneBar10.SetActive(false);
        }else if (playerData.playerEnergy == 8){
            eneBar1.SetActive(true);
            eneBar2.SetActive(true);
            eneBar3.SetActive(true);
            eneBar4.SetActive(true);
            eneBar5.SetActive(true);
            eneBar6.SetActive(true);
            eneBar7.SetActive(true);
            eneBar8.SetActive(true);
            eneBar9.SetActive(false);
            eneBar10.SetActive(false);
        }else if (playerData.playerEnergy == 9){
            eneBar1.SetActive(true);
            eneBar2.SetActive(true);
            eneBar3.SetActive(true);
            eneBar4.SetActive(true);
            eneBar5.SetActive(true);
            eneBar6.SetActive(true);
            eneBar7.SetActive(true);
            eneBar8.SetActive(true);
            eneBar9.SetActive(true);
            eneBar10.SetActive(false);
        }else if (playerData.playerEnergy == 10){
            eneBar1.SetActive(true);
            eneBar2.SetActive(true);
            eneBar3.SetActive(true);
            eneBar4.SetActive(true);
            eneBar5.SetActive(true);
            eneBar6.SetActive(true);
            eneBar7.SetActive(true);
            eneBar8.SetActive(true);
            eneBar9.SetActive(true);
            eneBar10.SetActive(true);
        }
    }

    void UpdateEnergyText(int storedEner)
    {
        enertxt.text = storedEner + " / 10";
    }
}
