using UnityEngine;

[CreateAssetMenu(fileName = "Passivemask", menuName = "Scriptable Objects/Passivemask")]
public class Passivemask : MaskSystem
{
    public override void PassiveAbility()
    {
        Debug.Log(Description);
    }
}
