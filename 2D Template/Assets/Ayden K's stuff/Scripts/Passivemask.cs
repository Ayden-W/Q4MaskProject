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
    public Healthsystem Healthsystem;

    public override void OnEquip(Playerscript player)
    {        
        Debug.Log(Description);
        yes?.Passives();

        // raise the player's stats
        if (yes)
        {
            player.Defence *= yes.Defence;
            player.Damage *= yes.DMG;
            Debug.Log(player.Damage);
            Debug.Log(player.Defence);
        }
        else
        {
            Debug.Log(player.Damage);
            Debug.Log(player.Defence);
        }
    }

    public override void OnUpdate(Playerscript player)
    {

    }

    public override void OnUnequip(Playerscript player)
    {
        // lower the player's stats
        player.Defence /= yes.Defence;
        player.Damage /= yes.DMG;
    }
}
