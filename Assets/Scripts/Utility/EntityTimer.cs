using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utility;

public abstract class EntityTimer
{
    private TimerUtil _timer_util;
    EntityTimer()
    {
        _timer_util = new TimerUtil();
    }

    public float seconds_passed => _timer_util.seconds_passed;
}
