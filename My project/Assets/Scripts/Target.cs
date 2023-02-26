using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        Debug.Log("target hit");
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Debug.Log("target dead");
            Destroy(gameObject);
        }
        Debug.Log("Health = " + currentHealth);
    }
}