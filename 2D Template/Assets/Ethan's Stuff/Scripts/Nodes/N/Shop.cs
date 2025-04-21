using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : NodeList
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void OnClick()
    {
        SceneManager.LoadScene("Shop");
    }
}
