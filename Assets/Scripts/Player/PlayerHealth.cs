using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private float playerHealth = 100f;
    public bool isPlayerDeath = false;

    public Text helthText;

    private void Awake()
    {

    }

    private void Update()
    {
        helthText.text = playerHealth.ToString();
    }
    public void ReducePlayerHelath(float reduceHealth)
    {
        if (playerHealth > 0f)
        {
            print("Health Reduce " + playerHealth);
            playerHealth -= reduceHealth;
        }
        else
        {
            print("player Death");
            isPlayerDeath = true;
        }

    }
}
