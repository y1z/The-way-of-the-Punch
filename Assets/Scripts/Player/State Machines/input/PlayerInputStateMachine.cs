

public abstract class PlayerInputStateMachine : IStateMachine
{
    public bool verify_state()
    {
        throw new System.NotImplementedException();
    }

    public void execute_state()
    {
        throw new System.NotImplementedException();
    }

    public IStateMachine change_state()
    {
        throw new System.NotImplementedException();
    }

    public virtual PlayerActions select_action()
    {
        return PlayerActions.NONE;
    }

}