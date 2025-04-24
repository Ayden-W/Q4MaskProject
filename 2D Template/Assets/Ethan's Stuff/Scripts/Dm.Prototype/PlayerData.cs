using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int health;

    public PlayerData (BattleHandler player)
    {
        health = player.PlayerHealth;
    }
}
