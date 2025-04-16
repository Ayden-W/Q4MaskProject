using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fight : MonoBehaviour
{
    [SerializeField] public GameObject node;
    [SerializeField] public Sprite Icon;
    [SerializeField] public string Type;
    [SerializeField] public bool inRange;

    public void OnMouseDown()
    {   if (node & inRange == true )
        SceneManager.LoadScene("sceneName");  // Scene Name would be the node it is in this case Fight / EE (Enemy Encounter)
    }


}
