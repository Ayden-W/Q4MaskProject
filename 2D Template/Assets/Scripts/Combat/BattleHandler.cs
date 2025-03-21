using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    //Character spawns useing prefabs
    [SerializeField] private Transform pfCharacter;
    [SerializeField] private Transform pfEnemy;
    public int EnemyspawnX = 4;
    public int EnemyspawnY = 0;
    public int PlayerspawnX = -4;
    public int PlayerspawnY = 0;
    private void Start()
    {
        //Instantiate(pfCharacter, new Vector3(PlayerspawnX, PlayerspawnY), Quaternion.identity);
        //Instantiate(pfEnemy, new Vector3(EnemyspawnX, EnemyspawnY), Quaternion.identity); 
        spawnCharacter(true);
        spawnCharacter(false);
    }
        private void spawnCharacter(bool isPlayerTeam)
    {
        Vector3 position;
        if (isPlayerTeam)
        {
            position = new Vector3(PlayerspawnX, PlayerspawnY);

        }
        else
        {
            position = new Vector3(EnemyspawnX, EnemyspawnY);
        }
        Instantiate(pfEnemy, new Vector3(EnemyspawnX, EnemyspawnY), Quaternion.identity);
        Instantiate(pfCharacter, new Vector3(PlayerspawnX, PlayerspawnY), Quaternion.identity);
    }
}
    

