using System;
using UnityEngine;

public class CharacterBattle : MonoBehaviour
{
    private State state;
    private Vector3 slideTargetPosition;
    private Action OnSlideComplete;
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
    public void Setup(bool isPlayerTeam)
    {
        if (isPlayerTeam)
        {
            // set Anim and Texture

            //characterBase.
            //characterBase.GetMaterial().mainTexture=
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
                if (Vector3.Distance(GetPosition(), slideTargetPosition)<reachedDistance)
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
    public void Attack(CharacterBattle targetCharacterBattle, Action onAttackComplete)
    {
        GetPosition();
        Vector3 startingPosition = GetPosition();
        slideTargetPosition = targetCharacterBattle.GetPosition() + (GetPosition() - targetCharacterBattle.GetPosition()).normalized /3f;
        Debug.Log(startingPosition);
        SlideToPosition(slideTargetPosition, () =>
        {
            //Arrived and Attack target
            state = State.Busy2;
            Vector3 attackDir = (targetCharacterBattle.GetPosition() - GetPosition()).normalized;
            //CharacterBase.PlayAnimAttack(attackDir, null, () => {
            //characterBase.PlayAnimIdle(attackDir);
            Debug.Log("Attack");


            //attack completed, Slide back
            SlideToPosition(startingPosition, () =>
            {
                //slide back completed

                state = State.Idle;
                this.slideTargetPosition = targetCharacterBattle.GetPosition();
                onAttackComplete();
                return;
            });
            //});
        });
        
    }
    private void SlideToPosition(Vector3 position, Action OnSlideComplete)
    {
        this.slideTargetPosition = position;
        this.OnSlideComplete = OnSlideComplete;
        state = State.Sliding;
    }
}
