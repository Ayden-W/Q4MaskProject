using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public float CurrentHealth;
    public float MaxHealth;
    public float TradeBeads;
    public List<MaskSystem> Inventory;

    public float Damage;
    public float Defence;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (var item in Inventory)
        {
            Debug.Log(item.name);
            item.OnEquip(this);

        }

    }

    public void UpdateMasks()
    {
        foreach (var item in Inventory)
        {
            Debug.Log(item.name);
            item.OnEquip(this);
        }
    }
}

