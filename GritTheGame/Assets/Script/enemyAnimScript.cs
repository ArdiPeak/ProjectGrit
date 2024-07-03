using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAnimScript : MonoBehaviour
{
    public Animator animator;
    public turnManager actionAnim;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (actionAnim.playerTurn == false){       //enemy will atk
            StartCoroutine(AnimDuration());
    }

    IEnumerator AnimDuration(){
        
        animator.SetBool("isTeachAtk", true);

        yield return new WaitForSeconds(1);

        animator.SetBool("isTeachAtk", false);
    }
    }
}
