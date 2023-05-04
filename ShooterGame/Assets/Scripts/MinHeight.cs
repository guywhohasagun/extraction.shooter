//teleports enemies if they fall of the map
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinHeight : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0, 3, 64); // teleports enemy 
        }
    }
}
