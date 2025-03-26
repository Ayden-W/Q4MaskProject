using UnityEngine;

[CreateAssetMenu(fileName = "PassiveAbilitys", menuName = "Scriptable Objects/PassiveAbilitys")]
public class PassiveAbilitys : PassiveBuff
{
    
    public override void Passives()
    {
        Debug.Log("Passives are working");
    }
}
