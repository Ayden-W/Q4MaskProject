using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
public class Collecting : MonoBehaviour
{
    public List<MaskSystem> listOfMasks;
    public Playerscript Playerscript;
    private int randomInt;
   public void AddToList()
    {
        randomInt = Random.Range(0, listOfMasks.Count);
        Playerscript.Inventory.Add(listOfMasks[randomInt]);
        //Playerscript.UpdateMasks();

        listOfMasks[randomInt].OnEquip(Playerscript);
    }

    public void Add(MaskSystem mask)
    {
        Playerscript.Inventory.Add(mask);
        mask.OnEquip(Playerscript);
    }

    public void Remove(MaskSystem mask)
    {
        Playerscript.Inventory.Remove(mask);
        mask.OnUnequip(Playerscript);
    }
}
