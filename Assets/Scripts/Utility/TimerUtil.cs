using System;
using UnityEngine;

namespace Utility
{
    public class TimerUtil
    {
        private float _starting_time;

        public TimerUtil()
        {
            start_timing();
        }
        
        public void start_timing()
        {
            _starting_time = Time.time;
        }

        
        public float seconds_passed => Time.time - _starting_time;
    }
}