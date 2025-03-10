using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //Script for the slider
    public Slider slider;

    public void SetMaxHealth(float maxHealth)
    {
        slider.maxValue = maxHealth;
        slider.value = maxHealth;
    }

    public void SetHealth(float currentHealth)
    {
        slider.value = currentHealth;
    }
}
