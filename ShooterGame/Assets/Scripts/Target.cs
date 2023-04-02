//code for the basic enemies
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //max and current health
    public float maxHealth = 100f;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth; //sets the current health max health when the scene starts
    }

    public void TakeDamage(float damage) // method to take damage and disappear when destroyed 
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