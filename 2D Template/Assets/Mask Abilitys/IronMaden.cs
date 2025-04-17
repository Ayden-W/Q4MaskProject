using System.Collections;
using UnityEngine;

public class IronMaden : MonoBehaviour
{
    private HealthBar healthBar;
    private Healthsystem healthSystem;
    public BattleHandler BattleSystem;
    
    public int BloodStacks;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BloodStacks = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        BattleSystem.Stack = BloodStacks;
        if (BloodStacks>7)
        {
            BloodStacks = 7;
            healthSystem.Damage(10);
        }
    }

    public void UseStacks()
    {
        
        
            if (BloodStacks > 5)
            {
                healthSystem.Heal(40);
            }
        
    }
}
