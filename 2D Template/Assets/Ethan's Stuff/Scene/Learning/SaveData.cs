
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct SaveData
{
    public int health; // How much life left till your untimely demise
    public int maxHealth; // How much of a beating you can take before withering away
    public bool isAlive;  // Yo are you alive?
    public float damage; //Dmg output
    public List<MaskSystem> Inventory;  // Inventory, where are you carrying these?
    public int seed; // Current world, CHICKEN JOCKEY
    public int currentNode; // Current position on the map, Zoro.
    public bool shouldGenerate; //Saying if  it should or shouldn't load a map.
    public int potions; // So people can't just spam heal like they are Ness in smash spamming pk fire. >:(
    //Holds variables that will be saved
}