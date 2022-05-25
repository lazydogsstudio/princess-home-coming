using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float jumpForce = 6f;
    public float moveSpeed = 40f;
    private bool isMove;
    private float moveDir;

    private Rigidbody2D playerRB;
    private PlayerAnimation playerAnim;
    private GameObject soundManager;
    private PlayerSoundFx playerSoundFx;

    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<PlayerAnimation>();



        soundManager = GameObject.Find("Sound Manager");
        playerSoundFx = soundManager.GetComponent<PlayerSoundFx>();

    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 6)
        {
            isGrounded = true;
            playerAnim.JumpAnimation(false);

        }
    }



    void FixedUpdate()
    {
        MoveDir();
    }


    // Movement Controler
    public void Idel()
    {
        isMove = false;
        moveDir = 0f;

        playerAnim.WalkAnimation(false);
    }


    // Player Movement Left Right
    public void Move(float dir)
    {
        isMove = true;
        moveDir = dir;

    }

    // Player Jump Function
    public void Jump()
    {
        if (isGrounded)
        {
            playerSoundFx.PlayJumpSound();
            playerAnim.JumpAnimation(true);
            playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
        else
        {
            playerRB.AddForce(Vector2.zero);
        }
    }


    void MoveDir()
    {
        if (isMove)
        {
            playerSoundFx.PlayWalkSound();
            playerAnim.WalkAnimation(true);
            transform.localScale = new Vector3(-moveDir, 1f, 1f);
            playerRB.AddForce(Vector2.right * moveSpeed * Time.fixedDeltaTime * moveDir * 10f);
        }
        else
        {
            playerRB.AddForce(Vector2.zero);
        }

    }



}
