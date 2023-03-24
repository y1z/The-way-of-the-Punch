using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using TextMeshPro = TMPro.TextMeshPro;

public class HealthBar : MonoBehaviour
{
    /// <summary>
    /// Used to know to who the health bar belongs to
    /// </summary>
    public enum ID
    {
        Player,
        Opponet
    } 
    
    private Slider _slider;
    public float health_bar_value = 1.0f;

    public ID id; 
    // Start is called before the first frame update
    void Start()
    {
        _slider = GetComponent<Slider>();
        health_bar_value = _slider.value;
    }

    // Update is called once per frame
    void Update()
    {
        health_bar_value = Mathf.Clamp(health_bar_value, 0.0f, 1.0f);
        _slider.value = health_bar_value;
    }
    
    
    public void set_health_percent(float percent)
    {
        health_bar_value = percent;
    }

    public void lower_health_percent(float percent)
    {
        health_bar_value = health_bar_value - percent;
    }

    // increment 
    public void increment_health_percent(float percent)
    {
        health_bar_value = health_bar_value + percent;
    }
    
    
    
}