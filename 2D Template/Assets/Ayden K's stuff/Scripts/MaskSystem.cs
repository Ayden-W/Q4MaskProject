using UnityEngine;

public abstract class MaskSystem : ScriptableObject
{
    public string ID;
    public string itemName;
    public string Description;

    public abstract void PassiveAbility();
    
}
