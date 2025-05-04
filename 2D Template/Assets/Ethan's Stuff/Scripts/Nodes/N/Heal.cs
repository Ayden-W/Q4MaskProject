using UnityEngine;

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
        SaveDataController.Instance.Current.health += 10;

        if(SaveDataController.Instance.Current.health > SaveDataController.Instance.Current.maxHealth)
        {
            SaveDataController.Instance.Current.health = SaveDataController.Instance.Current.maxHealth;
        }

        Debug.Log("Wow You healed at full hp, nice");

    }
}
