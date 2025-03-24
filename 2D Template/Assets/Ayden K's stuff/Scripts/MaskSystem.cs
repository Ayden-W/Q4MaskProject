using UnityEngine;

public abstract class MaskSystem : ScriptableObject
{
    public string ID;
    public string itemName;
    [TextArea] public string Description;

    public abstract void PassiveAbility();
    
}
