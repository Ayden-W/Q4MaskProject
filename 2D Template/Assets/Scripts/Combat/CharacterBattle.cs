using System;
using UnityEngine;

public class CharacterBattle : MonoBehaviour
{
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
    public Vector3 GetPosition()
    {
        return transform.position;
    }
    public void Attack(CharacterBattle targetCharacterBattle, Action onAttackComplete)
    {
        Vector3 attackDir = (targetCharacterBattle.GetPosition() - GetPosition()).normalized;
        //CharacterBase.PlayAnimAttack(attackDir, null, () => {
        //characterBase.PlayAnimIdle(attackDir);
        Debug.Log("Attack");
        //});
    }
}
