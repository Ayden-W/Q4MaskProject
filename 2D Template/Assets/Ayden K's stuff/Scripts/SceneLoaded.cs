using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoaded : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
