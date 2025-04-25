using UnityEngine;

[System.Serializable]
public class PlayerData
{
        public int health;
        public int MaxHealth;

    public PlayerData(PlayerData playerHealth)
    {
        health = playerHealth.health;
        MaxHealth = playerHealth.MaxHealth;

    }

}
