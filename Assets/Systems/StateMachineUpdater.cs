public class StateMachineUpdater : MonoBehaviour
{
    private StateMachine stateMachine;
    void Start()
    {
        stateMachine = new SMExample();
    }

    void Update()
    {
        stateMachine.Update();
    }

    void SetStateMachine(StateMachine newSM)
    {
        stateMachine = newSM();
        stateMachine.EnterState();
    }
}
