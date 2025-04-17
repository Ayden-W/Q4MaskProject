using NUnit.Framework;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NodeList : MonoBehaviour
{
    [SerializeField] public GameObject node;
    [SerializeField] public Sprite Icon;
    [SerializeField] public string Type;
    [SerializeField] public bool inRange; /*=> */
    [SerializeField] public string sceneName;
    private typings NL;

    void Update()
    {
        Range();
    }
    private void Start()
    {
        
    }

    public void Range()
    {
       
    }
    public void OnMouseDown()
    {
        Debug.Log("Bonk");
        if (node && inRange == true)
        {
            
            SceneManager.LoadScene(sceneName);
        }

        
        
        
    }
    
    

}
