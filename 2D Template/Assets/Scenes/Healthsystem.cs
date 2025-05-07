
using System;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
public class Healthsystem 
{
    public BattleHandler battleHandler;
    public event EventHandler OnHealthChanged;
    public int health;
    private int MaxHealth;
   


    
    
    public Healthsystem(int currentHealth, int Maxhealth) 
    {
        this.MaxHealth = Maxhealth;
        health = currentHealth;
    }   
    public int GetHealth()
    {
        return health;
    }
    public float GetHealthPercent()
    {
        return (float) health / MaxHealth;
    }
    public void Damage(int damageAmount)
    {
        

        health -= damageAmount;
        if (health <= 0) 
        { 
            health = 0;

            if (battleHandler.enemyHealth <= 0)
            {
                //win
                SceneManager.LoadScene("GridTest");
            }


            if (!SaveDataController.Instance.Current.isAlive)
            {

                SaveDataController.Instance.DeleteData();
                SceneManager.LoadScene("Main menu");
                
            }

        }



        if (OnHealthChanged != null)
        {
            OnHealthChanged(this, EventArgs.Empty);
            

        }
        
    }
    public void Heal(int healAmount)
    {
        if (SaveDataController.Instance.Current.potions > 0)
        {
         health += healAmount;
            SaveDataController.Instance.Current.potions--;
         if (health > MaxHealth) health = MaxHealth;
         if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
        }
    }
   
    public void SetupHealthBar()
    {
        OnHealthChanged(this, EventArgs.Empty);
    }
    
}
