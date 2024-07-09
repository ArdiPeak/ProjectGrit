using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnim : MonoBehaviour
{
    public Animator animator;
    
    public void EnemyAnimAtk(){
        animator.SetBool("enemyAtk", true);
    }
    public void EnemyAnimIdle(){
        animator.SetBool("enemyAtk", false);
    }
}
