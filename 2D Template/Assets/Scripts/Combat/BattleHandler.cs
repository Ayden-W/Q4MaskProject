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
    public bool IsBoss;
    public int Stack = 0;
    public bool Increased;
    public int enemyHealth = 100;
    private CharacterBattle playerCharacterBattle;
    private CharacterBattle enemyCharacterBattle;
    private CharacterBattle Attack;
    private CharacterBattle activeCharacterBattle;
    public Healthsystem Heal;
    public string DeathScene = "Main menu";
    private State state;

    private IronMaden IronMaden;

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
        //boss
       
        
        if (IsBoss == true)
        {
            enemyHealth = 275;
        }
        //Enemy
        enemySystem = new Healthsystem(enemyHealth, enemyHealth);
        enemyHealth = enemySystem.health;
        Transform HealthBartransform = Instantiate(PFHealthBar, new Vector3(0, 6), Quaternion.identity);
        HealthBar healthBar = HealthBartransform.GetComponent<HealthBar>();
        healthBar.Setup(enemySystem);
        enemySystem.SetupHealthBar();
        
       
        playerCharacterBattle.Setup(true, enemySystem);
           
        //Player
        playerSystem = new Healthsystem(SaveDataController.Instance.Current.health, SaveDataController.Instance.Current.maxHealth);
        Transform HealthBartransform2 = Instantiate(PFHealthBar, new Vector3(0, -5), Quaternion.identity);
        HealthBar healthBar2 = HealthBartransform2.GetComponent<HealthBar>();
        healthBar2.Setup(playerSystem);
        playerSystem.SetupHealthBar();

       
        


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
        SaveDataController.Instance.Current.health = playerSystem.health;
        SaveDataController.Instance.Current.isAlive = SaveDataController.Instance.Current.health > 0;
        
    }
    public void AttackButton()
    {
        if (state == State.WaitingForPlayer)
        {

           
                state = State.Busy1;
                Increased = true;
                playerCharacterBattle.Attack(enemyCharacterBattle, () =>
                {
                    ChooseNextActiveCharacter();


                });
            


            if (state == State.Busy1 && Increased == true)
            {
                Stack++;
                Increased = false;

                Debug.Log("Stack Increase" + Stack);

            }

        }
    }
    public void healButton() 
    {
        if (state == State.WaitingForPlayer)
        {
            state = State.Busy1;
            {
                playerSystem.Heal(30);
                ChooseNextActiveCharacter();
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

