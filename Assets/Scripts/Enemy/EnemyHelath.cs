using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHelath : MonoBehaviour
{
    // Start is called before the first frame update

    private float enemyHealth = 100f;
    private bool isEnemyDeath;


    void DestroyEnemy()
    {
        Destroy(gameObject, 1f);
    }

    public void ReduceHealth(float healthValue)
    {

        print("Health " + enemyHealth);

        if (enemyHealth > 0)
        {
            enemyHealth -= healthValue;

        }
        else
        {
            DestroyEnemy();
        }
    }
}
