using UnityEngine;

[System.Serializable]
public class PlayerData
{
        public int health = 175;
        public int MaxHealth = 175;

    public PlayerData(PlayerData playerHealth)
    {
        health = playerHealth.health;
        MaxHealth = playerHealth.MaxHealth;

    }

}
