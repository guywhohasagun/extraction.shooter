//gun script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float gunDamage = 100f; //gun damage
    public float gunRange = 100F; //gun range

    public AudioClip[] sounds; //aray of sounds the gun makes when you fire
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public Camera fpsCam;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //calls the shoot() method when mb1 is clicked and plays a random sound from the array
        {
            shoot();
            int randomIndex = Random.Range(0, sounds.Length);
            audioSource.clip = sounds[randomIndex];
            audioSource.Play();
        }
    }

    void shoot() //the shoot() method sends a raycast where the player is aiming and makes the enemy if you hit it take damage
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, gunRange))
        {
            Debug.Log(hit.transform.position + " " + hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            BossTarget bossTarget = hit.transform.GetComponent<BossTarget>();

            if (target != null)
            {
                target.TakeDamage(gunDamage);
            }

            if (bossTarget != null)
            {
                bossTarget.TakeDamage(gunDamage);
            }
        }
        
    }
}
