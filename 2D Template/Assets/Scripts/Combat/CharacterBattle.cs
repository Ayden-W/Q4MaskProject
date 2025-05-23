using System;
using UnityEngine;

public class CharacterBattle : MonoBehaviour
{
   
    public Healthsystem healthSystem;
    public HealthBar healthBar;

    private State state;
    private Vector3 slideTargetPosition;
    private Action OnSlideComplete;
    public bool Isattacking;
    public bool EnemyAtk = false;
    public Animator Anim;
    public Animator EnemyAnim;
    private enum State
    {
        Idle,
        Sliding,
        Busy2,
    }
    private void Awake()
    {

        state = State.Idle;
    }
    public void Setup(bool isPlayerTeam, Healthsystem System)
    {
        healthSystem = System;
        if (isPlayerTeam)
        {

            // set Anim and Texture

            
        }
        else
        {
            // enemy sprite and anim 
            //7min in video https://www.youtube.com/watch?v=0QU0yV0CYT4&t=413s

            //characterBase.();
            //characterBase.GetMaterial().mainTexture = BattleHandler.getInstance(). EnemySpritesheet
        }
    }
    private void Update()
    {
        if (EnemyAnim)
        {
            Anim.SetBool("EnemyAtk", EnemyAtk);
        }
        if (Anim)
        {
            Anim.SetBool("IsAttacking", Isattacking);
            
        }
        
        Debug.Log(state);
        switch (state)
        {
            case State.Idle:
               
                break;
            case State.Busy2:
                break;
            case State.Sliding:
                float slideSpeed = 10f;
                transform.position += (slideTargetPosition - GetPosition()) * slideSpeed * Time.deltaTime;

                float reachedDistance = .1f;
                if (Vector3.Distance(GetPosition(), slideTargetPosition) < reachedDistance)
                {
                    // arrived at slide target POS
                    transform.position = slideTargetPosition;
                    OnSlideComplete();
                }
                break;
                     
        }
    }
    public Vector3 GetPosition()
    {
        return transform.position;
    }
    //Melee attack
    public void Attack(CharacterBattle targetCharacterBattle, Action onAttackComplete)
    {
        EnemyAtk = true;
        Isattacking = true;
        GetPosition();
        Vector3 startingPosition = GetPosition();
        slideTargetPosition = targetCharacterBattle.GetPosition() + (GetPosition() - targetCharacterBattle.GetPosition()).normalized / 3f;
       
        SlideToPosition(slideTargetPosition, () =>
        {
            //Arrived and Attack target
            state = State.Busy2;
            Vector3 attackDir = (targetCharacterBattle.GetPosition() - GetPosition()).normalized;

            //Animation here
            
            Debug.Log("Attack");
            healthSystem.Damage((int)SaveDataController.Instance.Current.damage);
           

           

            //attack completed, Slide back
            SlideToPosition(startingPosition, () =>
            {

                //slide back completed
                Isattacking = false;
                state = State.Idle;
                this.slideTargetPosition = targetCharacterBattle.GetPosition();
                
                onAttackComplete();
                EnemyAtk = false;
                return;
               
            });
           
        });

    }

   
    private void SlideToPosition(Vector3 position, Action OnSlideComplete)
    {
        this.slideTargetPosition = position;
        this.OnSlideComplete = OnSlideComplete;
        state = State.Sliding;
        
    }
}
