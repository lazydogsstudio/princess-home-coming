using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{


    private Animator enemyAnim;
    void Awake()
    {
        enemyAnim = GetComponent<Animator>();
    }

    public void PlayAttack(bool isAttack)
    {
        enemyAnim.SetBool("isAttack", isAttack);
    }

    public void PlayWalk(bool isWalk)
    {
        enemyAnim.SetBool("isWalk", isWalk);
    }
}
