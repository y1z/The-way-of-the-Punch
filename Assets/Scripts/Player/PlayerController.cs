using System.Collections;
using System.Collections.Generic;
using Player.State_Machines;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerActions _current_action;
    private PlayerState _currentState;
    void Start()
    {
        _current_action = PlayerActions.NONE;
        _currentState = new PlayerStateIdle();
    }


    void Update()
    {
 ///    if (Input.GetButtonDown("Horizontal"))
 ///    {
 ///        float horizontal = Input.GetAxis("Horizontal");
 ///        if (horizontal > 0.0f)
 ///        {
 ///            _current_action = PlayerActions.RightDodge;
 ///        }
 ///        else
 ///        {
 ///            _current_action = PlayerActions.LeftDodge;
 ///        }
 ///    }
 ///    else if (Input.GetButtonDown("Vertical"))
 ///    {
 ///        if (Input.GetAxis("Vertical") > 0.0f)
 ///        {
 ///            _current_action = PlayerActions.HighPunch;
 ///        }
 ///        else
 ///        {
 ///            _current_action = PlayerActions.Block;
 ///        }
 ///    }

 ///    if (_current_action == PlayerActions.NONE)
 ///    {
 ///        return;
 ///    }
 ///    print("acction = " + _current_action.ToString());
 ///    _current_action = PlayerActions.NONE;
        _currentState.execute_state();
        if ( !_currentState.verify_state())
        {
            var new_state = _
            
        }
        else
        {
            Player
        }
 
 
    }
    
}
