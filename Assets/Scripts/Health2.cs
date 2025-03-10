using UnityEngine;

public class Health2 : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;


     public Death deathComponent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         deathComponent = GetComponent<Death>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void Heal(int amount)
    {
        currentHealth = currentHealth + amount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }

    public void TakeDamage(int amount)
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
