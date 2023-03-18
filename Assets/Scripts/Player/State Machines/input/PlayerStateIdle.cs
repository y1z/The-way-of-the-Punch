using System.Collections;
using System.Collections.Generic;
using Player.State_Machines;
using UnityEngine;

public class PlayerStateIdle : PlayerState
{
    
    public override bool verify_state()
    {
        return !Input.anyKeyDown;
    }

    public override void execute_state()
    {
    }

    public override IStateMachine change_state()
    {
        bool go_to_punch_state = Input.GetButtonDown("Punch");
        if (go_to_punch_state)
        {
            return new PlayerStatePunch();
        }
        return new PlayerStateIdle();
    }

    public override PlayerActions get_player_action()
    {
        return PlayerActions.NONE;
    }
}
