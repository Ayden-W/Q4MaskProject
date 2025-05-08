using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Learning");
    }
}
