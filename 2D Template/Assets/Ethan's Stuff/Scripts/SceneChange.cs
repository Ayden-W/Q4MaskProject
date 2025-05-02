using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{

    public void OnClick()
    {  
        // This is only for my Shope scene, because yes. Unless of course you have a button that were to change the scene to the GridTest scene.
        SceneManager.LoadScene("Grid Test");
    }
}
