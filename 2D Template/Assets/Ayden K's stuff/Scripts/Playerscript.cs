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

    // Update is called once per frame
    void Update()
    {
        // Don't forget to call a Mask's Equip and Unequip functions when they enter and leave your inventory.
    }

}
