using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Slider _slider;
    [SerializeField]
    private bool _debug = true;
    public float health_bar_value = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        _slider = GetComponent<Slider>();
        health_bar_value = _slider.value;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (_debug)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                health_bar_value = health_bar_value - .1f;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                health_bar_value = health_bar_value + .1f;
            }
        }

        health_bar_value = Mathf.Clamp(health_bar_value, 0.0f, 1.0f);
        _slider.value = health_bar_value;
    }
}