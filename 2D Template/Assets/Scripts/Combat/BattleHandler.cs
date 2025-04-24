using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleHandler : MonoBehaviour
{
    //Character spawns useing prefabs
    [SerializeField] private CharacterBattle pfCharacter;
    [SerializeField] private CharacterBattle pfEnemy;
    public int EnemyspawnX = 4;
    public int EnemyspawnY = 0;
    public int PlayerspawnX = -4;
    public int PlayerspawnY = 0;
    public int Stack = 0;
    public bool Increased;
    public int PlayerHealth;
    public int enemyHealth;
    private CharacterBattle playerCharacterBattle;
    private CharacterBattle enemyCharacterBattle;
    private CharacterBattle Attack;
    private CharacterBattle activeCharacterBattle;
    public string DeathScene = "Main menu";
    private State state;

    private IronMaden IronMaden;


    PlayerData PlayerData;
    public Healthsystem enemySystem;
    public Healthsystem playerSystem;

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
        enemySystem = new Healthsystem(100);
        enemyHealth = enemySystem.health;
        Transform HealthBartransform = Instantiate(PFHealthBar, new Vector3(0, 6), Quaternion.identity);
        HealthBar healthBar = HealthBartransform.GetComponent<HealthBar>();
        healthBar.Setup(enemySystem);

       
        playerCharacterBattle.Setup(true, enemySystem);
           
        //Player
        playerSystem = new Healthsystem(playerHealth.MaxHealth);
        PlayerHealth = playerSystem.health;
        Transform HealthBartransform2 = Instantiate(PFHealthBar, new Vector3(0, -5), Quaternion.identity);
        HealthBar healthBar2 = HealthBartransform2.GetComponent<HealthBar>();
        healthBar2.Setup(playerSystem);
      

       
        


        enemyCharacterBattle.Setup(true, playerSystem);


        enemySystem.battleHandler = this;
        playerSystem.battleHandler = this;
        
        // Debug.Log("Health:" + healthSystem.GetHealth());
        //healthSystem.Heal(40);
        //Debug.Log("Health:" + healthSystem.GetHealth());

    }

    private void Update()
    {
        enemyHealth = enemySystem.health;
        PlayerHealth = playerSystem.health;
        Debug.Log(PlayerHealth);
        if (state == State.WaitingForPlayer)
        {
           
            if (Input.GetKeyDown(KeyCode.Space))
            {
                state = State.Busy1;
                Increased = true;
                playerCharacterBattle.Attack(enemyCharacterBattle, () =>
                {
                    ChooseNextActiveCharacter();
                   

                });
            }
            if (Input.GetKeyDown(KeyCode.H)) { IronMaden.UseStacks(); }

            if (state == State.Busy1 && Increased == true)
            {
                Stack++;
               Increased= false;

                Debug.Log("Stack Increase" + Stack);
                
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

