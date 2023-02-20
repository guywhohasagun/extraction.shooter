using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUi : MonoBehaviour
{
    [SerializeField] private string newGameLevel1 = "SampleScene";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel1);
    }
}
