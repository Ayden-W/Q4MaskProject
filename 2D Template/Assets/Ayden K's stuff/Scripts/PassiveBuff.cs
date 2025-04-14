using UnityEngine;

public abstract class PassiveBuff : ScriptableObject
{
    public string ID;
    public string Name;
    //Stat bonuses and defects
    public float DMG;
    public float Defence;

    public abstract void Passives();
}
