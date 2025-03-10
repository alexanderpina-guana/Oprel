using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;
    //Connects to the health bar
    public HealthBar healthBar;

    public Death deathComponent;

    // Start is called before the first frame update
    void Start()
    {
        deathComponent = GetComponent<Death>();
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Heal(float amount)
    {
        currentHealth = currentHealth + amount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth = currentHealth - amount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if (currentHealth <= 0)
        {
            // Die
            deathComponent.Die();
        }

              healthBar.SetHealth(currentHealth);
    }

    public bool IsAlive()
    {
        if (currentHealth > 0)
        {
            return true;
        }

        return false;
    }
}
