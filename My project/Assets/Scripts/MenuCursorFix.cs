// unlocks the cursor when you enter the end screen
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCursorFix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; //unlocks the cursor
    }

}
