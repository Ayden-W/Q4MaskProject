using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class NodeList : ScriptableObject
{
    public GameObject node;
    //private void OnMouseDown()
    //{
    //    Enter();
    //}
    //public void Enter()
    //{
    //    SceneManager.LoadScene("sceneName");
    //}
    

    [SerializeField] public Sprite sprite;
    private bool inRange;
    [SerializeField] public string Type;

    private void Start()
    {
        
    }

    public void Range()
    {
       
    }
    public void OnMouseDown()
    {
        if (inRange)
        SceneManager.LoadScene("sceneName");
    }
    

}
