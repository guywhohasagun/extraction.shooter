//code for the ui buttons on the menu screen
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUi : MonoBehaviour
{
    [SerializeField] private string TestScene = "SampleScene"; //the sample scene level
    [SerializeField] private string Level1 = "Level1"; //what level the play button sends you to

    public void LoadTestScene()
    {
        SceneManager.LoadScene(TestScene);
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene(Level1);
    }
}
