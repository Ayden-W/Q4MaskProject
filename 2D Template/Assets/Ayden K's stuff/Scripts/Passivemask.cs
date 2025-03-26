using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.XR;

[CreateAssetMenu(fileName = "Passivemask", menuName = "Scriptable Objects/Passivemask")]
public class Passivemask : MaskSystem
{
    public PassiveAbilitys yes;     
    public List<ScriptableObject> SkillList;
    public List<ScriptableObject> PassiveList;
    public override void PassiveAbility()
    {        
        Debug.Log(Description);
        yes.Passives();       
    }
}
