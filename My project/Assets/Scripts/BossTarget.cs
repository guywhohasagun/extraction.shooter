using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossTarget : MonoBehaviour
{
    public float maxHealth = 200f;
    private float currentHealth;

    [SerializeField] private string Level = "Level1";

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
            SceneManager.LoadScene(Level);
        }
        Debug.Log("Health = " + currentHealth);
    }
}