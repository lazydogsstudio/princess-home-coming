using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 1.8f;
    private float moveDir = 1f;
    private Rigidbody2D enemyRB;
    public LayerMask groundLayer;

    private EnemyAnimation enemyAnimation;
    private PlayerHealth playerHealth;

    private bool isActtak;


    private void Awake()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        enemyAnimation = GetComponent<EnemyAnimation>();
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Move();

        if (isActtak)
        {
            playerHealth.ReducePlayerHelath(10);
        }

    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isActtak = true;
            enemyAnimation.PlayWalk(false);
            enemyAnimation.PlayAttack(true);
        }
        else
        {
            isActtak = false;
            enemyAnimation.PlayAttack(false);
            enemyAnimation.PlayWalk(true);

        }
        isActtak = false;
    }


    void Move()
    {



        if (Physics2D.Raycast(transform.position, Vector2.right, 3f, groundLayer))
        {
            moveDir = -1f;
        }
        if (Physics2D.Raycast(transform.position, Vector2.left, 3f, groundLayer))
        {
            moveDir = 1f;
        }

        transform.localScale = new Vector3(-moveDir, 1f, 1f);

        if (!isActtak)
        {
            enemyRB.AddForce(Vector2.right * moveSpeed * moveDir);
        }
        else
        {
            enemyRB.AddForce(Vector2.zero);
        }

    }

}
