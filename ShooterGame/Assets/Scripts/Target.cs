//code for the basic enemies
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //max and current health
    public float maxHealth = 100f;
    private float currentHealth;


    Material m_Material; //material var

    void Start()
    {
        currentHealth = maxHealth; //sets the current health max health when the scene starts
        m_Material = GetComponent<Renderer>().material; //gets the material
        StartCoroutine(ChangeColourCoroutine());
    }
    
    void Update()
    {
        
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

    IEnumerator ChangeColourCoroutine()
    {
        while (true)
        {
            //when currentHealth is less than 50 it blinks red and white
            while (currentHealth < 50)
            {
                m_Material.color = Color.red;
                Debug.Log("Colour changed");
                yield return new WaitForSeconds(0.5f); // one second delay
                m_Material.color = Color.white;
                Debug.Log("Colour changed");
                yield return new WaitForSeconds(0.5f); // one second delay
            }
            // If currentHealth is less than 50 wait for 0.1 seconds before checking again to prevent crashes and stuff
            yield return new WaitForSeconds(0.1f);
        }
    }
}