using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAngle : MonoBehaviour
{

    void Update()
    {
        float xDirection = Input.mousePosition.x;
        float yDirection = Input.mousePosition.y;

        Vector3 lookDirection = new Vector3(xDirection, yDirection, 0);

        
    }
}
