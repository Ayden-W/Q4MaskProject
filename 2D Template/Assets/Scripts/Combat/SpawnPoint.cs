using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Healthsystem Healthsystem;
    public BattleHandler BattleHandler;
    public struct EnemyInstantiate
    {
        //enemySystem = new Healthsystem(enemyHealth);
        //enemyHealth = enemySystem.health;
        //Transform HealthBartransform = Instantiate(PFHealthBar, new Vector3(0, 6), Quaternion.identity);
        //HealthBar healthBar = HealthBartransform.GetComponent<HealthBar>();
        //healthBar.Setup(enemySystem);
    }
    public GameObject[] spawnpoint;

    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    public void Spawn()
    {
        Instantiate(spawnpoint[Random.Range(0, spawnpoint.Length)], transform.position, Quaternion.identity);

    }
}
