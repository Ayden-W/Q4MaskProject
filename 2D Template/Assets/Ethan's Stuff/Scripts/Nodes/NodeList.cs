
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class NodeList : MonoBehaviour
{
    [SerializeField] public GameObject node;
    [SerializeField] public Sprite Icon;
    [SerializeField] public List<GameObject> typings;
    [SerializeField] public bool inRange; /*=> */
    [SerializeField] public string sceneName;

    [HideInInspector]public SpriteRenderer spriteRenderer;

    public static List<NodeList> list = new();

    public NodeList Next;

    protected virtual void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        
       
    }
    private void Start()
    {
        
    }

    public void Range()
    {
       
    }
    public void OnMouseDown()
    {
        if(list[SaveDataController.Instance.Current.currentNode].Next != this)
        {
            return;
        }




        Debug.Log("Bonk");

        OnClick();

        list[SaveDataController.Instance.Current.currentNode].spriteRenderer.color = Color.white;

        SaveDataController.Instance.Current.currentNode = list.IndexOf(this);

        spriteRenderer.color = Color.yellow;

        if (node && inRange == true)
        {
            Debug.Log("Ow");
            //SceneManager.LoadScene(sceneName);
            
        }
        else if(inRange == false)
        {
            Debug.Log("Bonk me you shall not, coward");
        }
        else
        {
            //Sadge
            //Debug.Log("Hey Paul they might be blind");
            //Debug.Log("Really? If I had a nick-");
            //Debug.Log("Stop making that joke it gets old...");
            //Debug.Log("Fineeee... We gonna send them to the tp maze? :D");
            //Debug.Log("No");
            //Debug.Log("Lame");
        }

        

    }

    public abstract void OnClick();

}
