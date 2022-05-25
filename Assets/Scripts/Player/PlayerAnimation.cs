using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void WalkAnimation(bool isWalk)
    {
        anim.SetBool("isWalk", isWalk);
    }

    public void JumpAnimation(bool isJump)
    {
        anim.SetBool("isJump", isJump);
    }

    public void AttckAnimation()
    {
        anim.SetTrigger("isAttack");

    }
}
