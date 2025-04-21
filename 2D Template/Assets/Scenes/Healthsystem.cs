
using System;
using UnityEngine.SceneManagement;
public class Healthsystem 
{
    BattleHandler battleHandler;
    public event EventHandler OnHealthChanged;
    public int health;
    private int MaxHealth;
   
    public Healthsystem(int Maxhealth) 
    {
        this.MaxHealth = Maxhealth;
        health = Maxhealth;
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
        if (health < 0) health = 0;
        
        if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
        if (battleHandler.PlayerHealth <= 0)
        {
            SceneManager.LoadScene("Main menu");
        }
    }
    public void Heal(int healAmount)
    {
        health += healAmount;
        if (health > MaxHealth) health = MaxHealth;
        if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }
}
