using UnityEngine;
using UnityEngine.SceneManagement;

public class EmptyNode : NodeList
{
    protected override void Awake()
    {
        base.Awake();

        current = this;
        spriteRenderer.color = Color.yellow;
    }

    public override void OnClick()
    {

    }
}
