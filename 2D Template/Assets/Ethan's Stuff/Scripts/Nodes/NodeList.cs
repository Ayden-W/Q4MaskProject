using NUnit.Framework;
using System.Collections.Generic;
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
            Debug.Log("Ow");
            SceneManager.LoadScene(sceneName);
        }
        else if(inRange == false)
        {
            Debug.Log("Bonk me you shall not, coward");
        }
        else
        {
            //Sadge
            Debug.Log("Hey Paul they might be blind");
            Debug.Log("Really? If I had a nick-");
            Debug.Log("Stop making that joke it gets old...");
            Debug.Log("Fineeee... We gonna send them to the tp maze? :D");
            Debug.Log("No");
            Debug.Log("Lame");
        }
        
        
        
    }
    

}
