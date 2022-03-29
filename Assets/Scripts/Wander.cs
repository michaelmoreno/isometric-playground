using UnityEngine;



public class Wander : State
{
    private float interval;
    private float force;
    private float timer;
    private StateMachine manager;
    
    public override void Enter(StateMachine manager)
    {
        Debug.Log("Wander");
        this.manager = manager;
        interval = manager.WanderInterval;
        force = manager.WanderForce;
        timer = interval;
    }

    public override void Execute()
    {
        Debug.Log(timer);
        // Debug.Log("Wandering");
        timer -= Time.deltaTime;
        if (timer <= 0) {
            Debug.Log("PASS");
            RandomPush();
            timer = interval;
        } 
    }

    private void RandomPush()
    {
        Debug.Log("Pushing");
        Vector3 direction = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
        manager.GetComponent<Rigidbody>().AddForce(direction * force, ForceMode.Impulse);
    }
}