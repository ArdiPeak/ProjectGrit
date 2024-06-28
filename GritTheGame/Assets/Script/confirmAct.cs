using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confirmAct : MonoBehaviour
{
    public playerScript playerData;
    public enemyTScript teachData;

    //if the confirm button clicked
    void OnMouseDown(){
            Debug.Log("Action Confirmed");
            teachData.hpOpp -= playerData.atkPlayer;
    }  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
