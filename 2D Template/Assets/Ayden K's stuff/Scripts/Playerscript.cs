using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public float HealthPool;
    public float MaxHealth;
    public float TradeBeads;
    public List<ScriptableObject> Inventory;
    public MaskSystem CurrentMask;
    public float Damage;
    public float Defence;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentMask.PassiveAbility();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
