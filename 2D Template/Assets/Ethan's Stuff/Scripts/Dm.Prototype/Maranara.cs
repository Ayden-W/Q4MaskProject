using UnityEngine;

public class Maranara : MonoBehaviour
{

   public void SavePlayer()
    {
        //DataManagement.SavePlayer(player);
    }

    public void LoaPlayer()
    {
        PlayerData data = DataManagement.LoadPlayer();

       
    }


}
