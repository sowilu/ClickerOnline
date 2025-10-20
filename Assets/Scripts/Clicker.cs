using UnityEngine;
using DG.Tweening;

public class Clicker : MonoBehaviour
{
    [Header("Animation Settings")] 
    public float duration = 0.5f;
    public Ease ease;
    
    [Header("Vfx")]
    public ParticleSystem particles;
    
    private int clicks;
    public int Clicks 
    {
        get
        {
            return clicks;
        }
        set
        {
            particles.Emit(value - clicks);
            clicks = value;
            UiManager.instance.UpdateClicks(clicks);
            
        }
    }
    
    private void OnMouseDown()
    {
        clicks++;
        UiManager.instance.UpdateClicks(clicks);
        transform.DOScale(Vector3.one, duration)
            .ChangeStartValue(Vector3.one * 1.5f)
            .SetEase(ease);
        particles.Emit(1);
    }
}
