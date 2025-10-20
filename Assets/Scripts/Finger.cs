using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finger : MonoBehaviour
{
    public int clickValue = 1;
    public float clickInterval = 0.5f;
    
    private Clicker clicker;
    void Start()
    {
        clicker = FindObjectOfType<Clicker>();
        InvokeRepeating(nameof(Click), clickInterval, clickValue);
    }

    void Click()
    {
        clicker.Clicks += clickValue;
    }
    
}
