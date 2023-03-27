using Unity.Burst;
using Unity.VisualScripting;

public static class Globals
{
    
    private const float minimal_time_unit = 1.0f / 60.0f;
    public static readonly float TIME_UNTIL_PUNCH_STATE_CHANGE = minimal_time_unit * 4.0f;


}