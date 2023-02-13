using System;
using UnityEditor;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 2f;
    public float yPos = 1f;
    // Update is called once per frame
    void Update()
    {
        float tSpeed = speed / 100;
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");


        Vector3 moveDirection = new Vector3(xDirection, yPos, zDirection);

        transform.position += moveDirection * tSpeed;
    }
}
