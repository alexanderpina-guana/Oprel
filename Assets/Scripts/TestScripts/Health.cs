using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;

    public Death deathComponent;

    // Start is called before the first frame update
    void Start()
    {
        deathComponent = GetComponent<Death>();
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
