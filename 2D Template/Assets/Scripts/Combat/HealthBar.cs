using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private Healthsystem healthSystem;
    public void Setup(Healthsystem healthSystem)
    {
        this.healthSystem = healthSystem;

        healthSystem.OnHealthChanged += Healthsystem_OnHealthChanged;
   
    }
    private void Healthsystem_OnHealthChanged(object sender, System.EventArgs e)
    {
        transform.Find("Bar").localScale = new Vector3(healthSystem.GetHealthPercent(), 1);
    }



        private void Update()
    {
        //transform.Find("Bar").localScale = new Vector3(healthSystem.GetHealthPercent(), 1);
    }
}
