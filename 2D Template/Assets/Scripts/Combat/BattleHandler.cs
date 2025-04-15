using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    //Character spawns useing prefabs
    [SerializeField] private CharacterBattle pfCharacter;
    [SerializeField] private CharacterBattle pfEnemy;
    public int EnemyspawnX = 4;
    public int EnemyspawnY = 0;
    public int PlayerspawnX = -4;
    public int PlayerspawnY = 0;

    private CharacterBattle playerCharacterBattle;
    private CharacterBattle enemyCharacterBattle;
    private CharacterBattle Attack;
    private CharacterBattle activeCharacterBattle;
    private State state;

    public Transform PFHealthBar;

    private enum State
    {
        WaitingForPlayer,
        Busy1
    }

    private void Start()
    {
        //Instantiate(pfCharacter, new Vector3(PlayerspawnX, PlayerspawnY), Quaternion.identity);
        //Instantiate(pfEnemy, new Vector3(EnemyspawnX, EnemyspawnY), Quaternion.identity); 

        
        playerCharacterBattle = SpawnCharacter(true);
        enemyCharacterBattle = SpawnCharacter(false);
        state = State.WaitingForPlayer;
        SetActiveCharacterBattle(playerCharacterBattle);
        
        //Enemy
        Healthsystem healthSystem = new Healthsystem(100);
        Transform HealthBartransform = Instantiate(PFHealthBar, new Vector3(0, 6), Quaternion.identity);
        HealthBar healthBar = HealthBartransform.GetComponent<HealthBar>();
        healthBar.Setup(healthSystem);

       
        Debug.Log("Health:" + healthSystem.GetHealthPercent());
        healthSystem.Damage(10);
        Debug.Log("Health:" + healthSystem.GetHealthPercent());
        playerCharacterBattle.Setup(true, healthSystem);
           
        //Player
        Healthsystem healthSystem2 = new Healthsystem(100);
        Transform HealthBartransform2 = Instantiate(PFHealthBar, new Vector3(0, -5), Quaternion.identity);
        HealthBar healthBar2 = HealthBartransform2.GetComponent<HealthBar>();
        healthBar2.Setup(healthSystem2);

       
        Debug.Log("Health:" + healthSystem2.GetHealthPercent());
        healthSystem2.Damage(10);
        Debug.Log("Health:" + healthSystem2.GetHealthPercent());

        enemyCharacterBattle.Setup(true, healthSystem2);


        // Debug.Log("Health:" + healthSystem.GetHealth());
        //healthSystem.Heal(40);
        //Debug.Log("Health:" + healthSystem.GetHealth());

    }

    private void Update()
    {
        if (state == State.WaitingForPlayer)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                state = State.Busy1;
                playerCharacterBattle.Attack(enemyCharacterBattle, () =>
                {
                    ChooseNextActiveCharacter();


                });
            }
           
        }
    }
    private CharacterBattle SpawnCharacter(bool isPlayerTeam)
    {
        Vector3 position;
        if (isPlayerTeam)
        {
            position = new Vector3(PlayerspawnX, PlayerspawnY);
            return Instantiate(pfCharacter, new Vector3(PlayerspawnX, PlayerspawnY), Quaternion.identity);
        }
        else
        {
            position = new Vector3(EnemyspawnX, EnemyspawnY);
            return Instantiate(pfEnemy, new Vector3(EnemyspawnX, EnemyspawnY), Quaternion.identity);
        }
        //Transform characterTransform = Instantiate(pfCharacter, position, Quaternion.identity);
        //CharacterBattle characterBattle = characterTransform.GetComponent<CharacterBattle>();
        //characterBattle.Setup(isPlayerTeam);
        //return characterBattle

    }
    private void SetActiveCharacterBattle (CharacterBattle characterBattle)
    {
        activeCharacterBattle = characterBattle;
    }
    private void ChooseNextActiveCharacter()
    {
        if (activeCharacterBattle == playerCharacterBattle)
        {
            SetActiveCharacterBattle(enemyCharacterBattle);
            state = State.Busy1;
            enemyCharacterBattle.Attack(playerCharacterBattle, () =>
            {
                ChooseNextActiveCharacter();
            });
        }
        else
        {
            SetActiveCharacterBattle(playerCharacterBattle);
            state = State.WaitingForPlayer;
        }
    }
}

