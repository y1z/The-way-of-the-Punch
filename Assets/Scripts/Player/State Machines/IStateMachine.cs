using UnityEngine;
public interface IStateMachine
{
    public bool verify_state();
    public void execute_state();
    public IStateMachine change_state();
}
