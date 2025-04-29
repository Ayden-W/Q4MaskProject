using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Win_Lose : MonoBehaviour
{
    public Healthsystem healthsystem;
    public BattleHandler battleHandler;
    public Start_game start_Game;
    public string levelName;

    public void LoadLevel()
    {
        StartCoroutine(MyCoroutine());
    }
    IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene(levelName);
    }
    public void LoadLevelAdditive()
    {
        StartCoroutine(MyCoroutine2());
    }
    IEnumerator MyCoroutine2()
    {
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene(levelName, LoadSceneMode.Additive);
    }

    public void Lose_Scene()
    {
        if (battleHandler.enemyHealth <= 0)
        {
            LoadLevel();
        }
    }
}
