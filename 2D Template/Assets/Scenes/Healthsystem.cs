
using System;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
public class Healthsystem 
{
    public BattleHandler battleHandler;
    public event EventHandler OnHealthChanged;
    //public int health;
    //public int MaxHealth;
     public PlayerData PlayerData;
     public EnemyData EnemyData;



    public Healthsystem(int Maxhealth) 
    {
        this.PlayerData.MaxHealth = Maxhealth;
        PlayerData.health = PlayerData.MaxHealth;
    }   

    public int GetHealth()
    {
        return PlayerData.health;
    }
    public float GetHealthPercent()
    {
        return (float) PlayerData.health / PlayerData.MaxHealth;
    }
    public void Damage(int damageAmount)
    {


        PlayerData.health -= damageAmount;
        if (PlayerData.health <= 0) 
        {
            PlayerData.health = 0;

            //playerHealth
            if (battleHandler.PlayerData.health == 0)
            {
                
                SceneManager.LoadScene("Main menu");
            } 

            //Actulay enemy health
            if (battleHandler.EnemyData._EH <= 0)
            {
                //win
            }
        }



        if (OnHealthChanged != null)
        {
            OnHealthChanged(this, EventArgs.Empty);
            

        }
        
    }
    public void Heal(int healAmount)
    {
        PlayerData.health += healAmount;
        if (PlayerData.health > PlayerData.MaxHealth) PlayerData.health = PlayerData.MaxHealth;
        if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }

    public void EHP(int _EHMP)
    {
        this.EnemyData._EHM = _EHMP;
        this.EnemyData._EH = _EHMP;
    }


}
