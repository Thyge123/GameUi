using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance;

    public int curHealth = 0;
    public int maxHealth = 100;

    public HealthBar healthBar;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        curHealth = maxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DamagePlayer(Random.Range(1, 10));
        }
    }

    public void DamagePlayer(int damage)
    {
        curHealth -= damage;

        healthBar.SetHealth(curHealth);
    }

    public void ResoreHealth(int value)
    {
        if (curHealth < maxHealth)
        {
            while (curHealth < maxHealth)
            {
                if (curHealth > maxHealth)
                {
                    curHealth = maxHealth;
                }
                else
                {
                    curHealth += value;
                }
            }
            healthBar.SetHealth(curHealth);
        }
    }
}