using UnityEngine;

public class Idle : State
{
    public override void Enter(StateMachine manager)
    {
        Debug.Log("Idle");
    }
    public override void Execute()
    {

    }
}