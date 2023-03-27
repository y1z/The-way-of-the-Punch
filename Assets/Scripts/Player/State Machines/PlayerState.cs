using Utility;

namespace Player.State_Machines
{
    public abstract class PlayerState : IStateMachine
    {
        public PlayerState()
        {
            state_timer = new TimerUtil();
            start_timing();
        }

        protected TimerUtil state_timer;
        
        public virtual bool verify_state()
        {
            throw new System.NotImplementedException();
        }

        public virtual void execute_state()
        {
            throw new System.NotImplementedException();
        }

        public virtual IStateMachine change_state()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns> The player action that belongs to the player state </returns>
        public abstract PlayerActions get_player_action();

        public void start_timing()
        {
            state_timer.start_timing();
        }

        public float seconds_passed => state_timer.seconds_passed;
    }
}