using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public Transform PFHealthBar;
    private void Start()
    {
        Healthsystem healthSystem = new Healthsystem(100);
       Transform HealthBartransform = Instantiate(PFHealthBar, new Vector3(0,10), Quaternion.identity);
        HealthBar healthBar = HealthBartransform.GetComponent<HealthBar>();
        healthBar.Setup(healthSystem);

        healthBar.Setup(healthSystem);
        Debug.Log("Health:" + healthSystem.GetHealthPercent());
        healthSystem.Damage(10);
        Debug.Log("Health:" + healthSystem.GetHealthPercent());
        
       // Debug.Log("Health:" + healthSystem.GetHealth());
        //healthSystem.Heal(40);
        //Debug.Log("Health:" + healthSystem.GetHealth());
    }
    
}
