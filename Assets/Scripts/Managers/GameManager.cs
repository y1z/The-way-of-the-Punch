using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private HealthBar _player_health_bar;
    private HealthBar _opponent_health_bar;
    

    private bool TEMP_set_on_player_health_bar = true;
    void Awake()
    {
        var health_bars = FindObjectsOfType<HealthBar>();
        
        foreach(HealthBar bar in health_bars )
        {
            if (HealthBar.ID.Player == bar.id)
            {
                _player_health_bar = bar;
            }
            else if (HealthBar.ID.Opponet == bar.id)
            {
                _opponent_health_bar = bar;
            }
            
        }

    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR

        HealthBar.ID TEMP_index; 
        if (TEMP_set_on_player_health_bar)
        {
            TEMP_index = HealthBar.ID.Player;
        }
        else
        {
            TEMP_index = HealthBar.ID.Opponet;
        }

        HealthBar bar_ref = null;
        switch (TEMP_index)
        {
            case  HealthBar.ID.Player:
                bar_ref = _player_health_bar;
                break;
            case  HealthBar.ID.Opponet:
                bar_ref = _opponent_health_bar;
                break;
        }
        
       if (Input.GetKeyDown(KeyCode.O))
       {
           bar_ref.increment_health_percent(0.10f);
       }

       if (Input.GetKeyDown(KeyCode.P))
       {
           bar_ref.lower_health_percent(0.10f);
       }

       if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
       {
           TEMP_set_on_player_health_bar = !TEMP_set_on_player_health_bar;
       }
        
#endif // UNITY_EDITOR
        
    }
}
