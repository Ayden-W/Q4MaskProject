using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fight : NodeList
{
    private int RandomInt;
    
    //[SerializeField] public GameObject node;
    //[SerializeField] public Sprite Icon;
    //[SerializeField] public string Type;
    //[SerializeField] public bool inRange;

    //public void OnMouseDown()
    //{   if (node & inRange == true )
    //    SceneManager.LoadScene("sceneName");  // Scene Name would be the node it is in this case Fight / EE (Enemy Encounter)



    public override void OnClick()
    {

        RandomInt = Random.Range(0, 50);
        if (RandomInt < 50)
        {
            SceneManager.LoadScene("Battle");
        }
       // else { "Other scenes" }

        // create a diffrent script for boss fights
    }

}
