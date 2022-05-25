using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public GameObject Weapon;
    private PlayerAnimation playerAnimation;
    private PlayerSoundFx playerSoundFx;
    private bool isActtak;
    // Start is called before the first frame update

    void Awake()
    {
        playerAnimation = GetComponent<PlayerAnimation>();
        playerSoundFx = GameObject.Find("Sound Manager").GetComponent<PlayerSoundFx>(); ;

    }


    private void OnCollisionEnter2D(Collision2D other)
    {


        if (other.gameObject.tag == "Enemy" && isActtak)
        {
            print("coolllide with enemy");
            other.gameObject.GetComponent<EnemyHelath>().ReduceHealth(5);
        }
        isActtak = false;

    }

    // Update is called once per frame

    public void Attack()
    {
        isActtak = true;
        playerAnimation.AttckAnimation();
        playerSoundFx.PlayAttackSound();
    }
}
