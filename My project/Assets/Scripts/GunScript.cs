using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float gunDamage = 100f;
    public float gunRange = 100F;

    public Camera fpsCam;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, gunRange))
        {
            Debug.Log(hit.transform.position);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(gunDamage);
            }
        }
        
    }
}
