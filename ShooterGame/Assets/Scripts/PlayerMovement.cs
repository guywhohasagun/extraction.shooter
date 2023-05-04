//code for the players movement
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller; //controls player controls i believe using this also makes it possible to use a controller 
    public float gravity = -9.81f; //strength of gravity 
    public float jumpHeight = 3f; //jump height

    Vector3 velocity;

    // ground check varibles 
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;

    public float speed = 12f;
    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //sets what it is to be grounded

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //changes the x and z if the player is using WASD
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z; //moves the player to the x and y varible 

        controller.Move(move * speed * Time.deltaTime); //this code is so the speed is bound to real time so you don't go slower when you have a higher frame rate

        if (Input.GetButtonDown("Jump") && isGrounded) //code for the player to jump
        {
            velocity.y = Mathf.Sqrt(jumpHeight * 2f * gravity);
        }

        velocity.y -= gravity * Time.deltaTime; //gravity 

        controller.Move(velocity * Time.deltaTime);

        if (transform.position.y < -10) //teleports the player if they fall off the map
        {
            transform.position = new Vector3(0, 3, 0);
        }
    }
}
