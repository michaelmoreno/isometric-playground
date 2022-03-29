using UnityEngine;

public class StateMachine : MonoBehaviour {

    public State CurrentState;
    public float WanderInterval = 3f;
    public float WanderForce = 15f;
    private State Idle = new Idle();
    private State Wander = new Wander();

    private void Start() {
        CurrentState = Wander;
        CurrentState.Enter(this);
    }

    private void Update() {
        CurrentState.Execute();
    }
}