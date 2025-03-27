using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public float CurrentHealth;
    public float MaxHealth;
    public float TradeBeads;
    public List<ScriptableObject> Inventory;
    public MaskSystem CurrentMask;
    public float Damage;
    public float Defence;
    public float Healing = 15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentMask.PassiveAbility();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void healing()
    {
        if (CurrentHealth <= MaxHealth)
        {
            CurrentHealth += Healing;
            Debug.Log("healing");
        }
        if (CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
            Debug.Log("max health");
        }
    }
}
