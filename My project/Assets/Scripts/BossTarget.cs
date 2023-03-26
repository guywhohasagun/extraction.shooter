//code for the bosses
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossTarget : MonoBehaviour
{
    public float maxHealth = 200f; //boss max health
    private float currentHealth; //boss current health

    public AudioClip[] sounds; //array of sounds the boss makes when has less than half health 
    private AudioSource audioSource;

    [SerializeField] private string Level = "Level1"; // what level you are sent to when you kill the boss

    void Start()
    {
        currentHealth = maxHealth; //sets the current health to the max health when the scene starts
    }

    void Update()
    {
        while (currentHealth < 100) // plays the array of sounds every second when the boss has less than 100 health
        {
            int randomIndex = Random.Range(0, sounds.Length);
            audioSource.clip = sounds[randomIndex];
            audioSource.Play();
        }
    }

    public void TakeDamage(float damage) //method for taking damage
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