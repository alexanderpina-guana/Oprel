using UnityEngine;

public class TargetDeath : SphereDeath
{
    private void Start()
    {
        //register instance
        if(GameManager.instance != null)
        {
            GameManager.instance.RegisterDeath();
        }
    }

    public override void Die()
    {
        
        
        //Unregister instance
        if(GameManager.instance != null)
        {
            GameManager.instance.UnregisterDeath();
        }
        
        //Call death
        base.Die();
    }

    private void OnDestroy()
    {
        //ensure unregistration
        if(GameManager.instance != null)
        {
            GameManager.instance.UnregisterDeath();

        }
    }
}
