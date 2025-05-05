using Unity.VisualScripting;
using UnityEngine;

public class PotionBuy : MonoBehaviour
{
    private bool soldOut = false;
    
    public void OnClick()
    {
        if (soldOut == false)
        {
            SaveDataController.Instance.Current.potions += 2;
            soldOut = true;
        }
        if (soldOut == true)
        {
            Debug.Log("They stare at you as if you are what they call a pot pig.");
        }
    }
    
}
