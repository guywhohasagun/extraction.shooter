using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitviy = 1000f; // mouse sensivity //to do add ui to change this in game

    public Transform playerBody;
    public Transform playerHead;
    float xRotation = 0f; // stores the x rotation of the player

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // hides the cursor 
    }

    void Update()
    {
        // gets the mouse axis
        float mouseX = mouseSensitviy * Input.GetAxis("Mouse X") * Time.deltaTime;
        float mouseY = mouseSensitviy * Input.GetAxis("Mouse Y") * Time.deltaTime; 

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // makes it so you can only look up and down 90 degrees

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX); // rotates the body along the X axis
    }
}
