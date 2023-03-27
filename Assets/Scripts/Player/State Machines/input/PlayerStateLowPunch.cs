using Player.State_Machines;
using Unity.Mathematics;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;


public class PlayerStateLowPunch : PlayerState
{
    private bool punch_again;
    private bool punch_high;

    public PlayerStateLowPunch() : base()
    {
        punch_again = false;
        punch_high = false;
    }
    
    public override bool verify_state()
    {
        if (state_timer.seconds_passed > Globals.TIME_UNTIL_PUNCH_STATE_CHANGE)
        {
            punch_again = false;
            return false;
        }
        


        return true;
    }

    public override void execute_state()
    {
        if (Input.GetButtonDown("Punch"))
        {
            punch_again = true;
        }

#if UNITY_EDITOR
        Debug.Log("Low Punch State");
#endif
        
        
    }

    public override IStateMachine change_state()
    {
        if(punch_again)
            return new PlayerStateLowPunch();

        return new PlayerStateIdle();
    }

    public override PlayerActions get_player_action()
    {
        if (punch_high)
        {
            return PlayerActions.HighPunch;
        }
        
        return PlayerActions.LowPunch;
    }
}