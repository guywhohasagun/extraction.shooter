using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUi : MonoBehaviour
{
    [SerializeField] private string TestScene = "SampleScene";
    [SerializeField] private string Level1 = "Level1";

    public void LoadTestScene()
    {
        SceneManager.LoadScene(TestScene);
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene(Level1);
    }
}
