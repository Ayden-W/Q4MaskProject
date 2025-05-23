
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using TMPro;
public class Collecting : MonoBehaviour
{
    public List<MaskSystem> listOfMasks;
    public Playerscript Playerscript;
    private int randomInt;

    public TMP_Text description;

   public void AddToList()
    {
        randomInt = Random.Range(0, listOfMasks.Count);
        SaveDataController.Instance.Current.Inventory.Add(listOfMasks[randomInt]);
        //Playerscript.UpdateMasks();

        listOfMasks[randomInt].OnEquip(Playerscript);
    }

    public void Add(MaskSystem mask)
    {
        SaveDataController.Instance.Current.Inventory.Add(mask);
        mask.OnEquip(Playerscript);
    }

    public void Remove(MaskSystem mask)
    {
        SaveDataController.Instance.Current.Inventory.Remove(mask);
        mask.OnUnequip(Playerscript);
    }

    public void PrintDescription(MaskSystem Mask)
    {
        description.SetText(Mask.Description);
    }
}
