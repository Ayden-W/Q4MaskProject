using UnityEngine;
using UnityEngine.SceneManagement;

public class Heal : NodeList
{
    SaveData saveData;
    Healthsystem healthsystem;
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
        //healthsystem?.Heal(10);
        SaveDataController.Instance.Current.health += 5;

        if(SaveDataController.Instance.Current.health > SaveDataController.Instance.Current.maxHealth)
        {
            SaveDataController.Instance.Current.health = SaveDataController.Instance.Current.maxHealth;
        }
        SceneManager.LoadScene("Shrine");

        Debug.Log("You found a shrine");

    }
}
