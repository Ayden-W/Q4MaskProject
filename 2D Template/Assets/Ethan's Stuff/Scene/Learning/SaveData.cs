
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct SaveData
{
    public int health;
    public int maxHealth;
    public bool isAlive;
    public float damage;
    public List<MaskSystem> Inventory;
    public int seed;
    public int currentNode;
    public bool shouldGenerate;
    //Holds variables that will be saved
}