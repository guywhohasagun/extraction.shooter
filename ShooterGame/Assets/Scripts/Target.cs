//code for the basic enemies
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //max and current health
    public float maxHealth = 100f;
    private float currentHealth;

    Material m_Material;

    void Start()
    {
        currentHealth = maxHealth; //sets the current health max health when the scene starts
    }
    
    void Update()
    {
        while (currentHealth > 50)
        {
            Invoke("Colourchange", 1f);s
        }
    }

    public void TakeDamage(float damage) // method to take damage and disappear when destroyed 
    {
        // this method is called in GunScript.cs
        Debug.Log("target hit");
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Debug.Log("target dead");
            Destroy(gameObject);
        }
        Debug.Log("Health = " + currentHealth);
    }

    public void colourChange()
    {
        Debug.Log("While loop working");
    }
}