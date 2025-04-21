using UnityEngine;

public class Heal : NodeList
{
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
        healthsystem.Heal(10);
      
        Debug.Log("Wow You healed at full hp, nice");

    }
}
