using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_game : MonoBehaviour
{
    public string LevelName;
    public Animator transition;

    public void LoadLevel()
    {
        StartCoroutine(MyCoroutine());

    }
    IEnumerator MyCoroutine()
    {
        transition.SetBool("Switch", true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(LevelName);
    }
    public void LoadLevelAdditive()
    {
        StartCoroutine (MyCoroutine2());
    }
    IEnumerator MyCoroutine2()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(LevelName, LoadSceneMode.Additive);

    }
}
