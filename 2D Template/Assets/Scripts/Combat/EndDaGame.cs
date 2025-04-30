using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDaGame : MonoBehaviour
{
    BattleHandler battleHandler;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (battleHandler.enemyHealth <= 0)
        {
            //win
            SceneManager.LoadScene("GridTest");
        }


        if (battleHandler.PlayerHealth <= 0)
        {

            SceneManager.LoadScene("MainMenu");
        }
    }
}
