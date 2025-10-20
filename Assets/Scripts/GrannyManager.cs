using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrannyManager : MonoBehaviour
{
    public int count;
    public float price = 10;
    public float bakeInterval = 1;
    public int bakeCount = 1;
    
    public UiButton shopButton;
    
    public Clicker clicker;

    private void Start()
    {
        InvokeRepeating(nameof(Bake), 0, bakeInterval);
    }

    void Bake()
    {
        if (count == 0) return;
        
        clicker.Clicks += count * bakeCount;
    }

    public void Buy()
    {
        if (clicker.Clicks >= price)
        {
            count++;
            clicker.Clicks -= (int)Mathf.Ceil(price);
            price *= 1.2f; //price increases by 20%
            
            shopButton.countText.text = count.ToString();
            shopButton.priceText.text = $"price: {(int)Mathf.Ceil(price)}";
        }
    }
}
