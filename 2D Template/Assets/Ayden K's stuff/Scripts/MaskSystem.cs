using UnityEngine;

public abstract class MaskSystem : ScriptableObject
{
    public string ID;
    public string itemName;
    public float SellPrice;
    public float Cost;
    [TextArea] public string Description;
    public bool Discardable;

    public abstract void PassiveAbility();
    
}
