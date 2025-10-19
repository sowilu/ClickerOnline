using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;

    [SerializeField]private TextMeshProUGUI clickText;
    
    void Awake() //before Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("More than one UiManager in scene.");
            Destroy(gameObject);
        }
    }

    public void UpdateClicks(int clicks)
    {
        clickText.text = clicks.ToString();
    }
}
