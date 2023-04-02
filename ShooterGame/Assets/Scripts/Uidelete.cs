// code to delete tutorial text after 15 seconds
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uidelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyGameObject", 15f); //calls the DestroyGameObject method after 15 seconds
    }

    void DestroyGameObject() //method to destroy the ui
    {
        Destroy(gameObject);
    }
}