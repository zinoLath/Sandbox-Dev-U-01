public class StateMachineExample : StateMachine
{
    private int test = 0;
    public void EnterState()
    {
        test = 0;
    }
    public void Update()
    {
        test++;
    }
}
