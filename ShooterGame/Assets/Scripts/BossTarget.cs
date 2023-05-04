//code for the bosses
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossTarget : MonoBehaviour
{
    public float maxHealth = 200f; //boss max health
    private float currentHealth; //boss current health

    [SerializeField] private string Level = "Level1"; // what level you are sent to when you kill the boss

    void Start()
    {
        currentHealth = maxHealth; //sets the current health to the max health when the scene starts
    }


    public void TakeDamage(float damage) //method for taking damage
        // this method is called in GunScript.cs
    {
        Debug.Log("target hit");
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Debug.Log("target dead");
            Destroy(gameObject);
            SceneManager.LoadScene(Level);
        }
        Debug.Log("Health = " + currentHealth);
    }
}