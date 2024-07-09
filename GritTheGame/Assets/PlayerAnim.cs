using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    public Animator animator;

    public void PlayerAnimAtk(){
        animator.SetBool("isplayerAtk", true);
    }
    public void PlayerAnimIdle(){
        animator.SetBool("isplayerAtk", false);
    }
}
