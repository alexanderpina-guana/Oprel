using UnityEngine;
using TMPro;

public class TargetDeath : SphereDeath
{

    public TextMeshProUGUI countText;
    public int pointValue = 1;
    
    private void Start()
    {

            //for the score
        if(countText != null)
        {
            SetCountText();
        }
        
        //register instance
        if(GameManager.instance != null)
        {
            GameManager.instance.RegisterDeath();
        }
    }

       void OnTriggerEnter2D(Collider2D other)
    {
            GameManager.instance.AddScore(pointValue);
            SetCountText();
            Destroy(other.gameObject);
        
    }

        //For the score
    void SetCountText()
    {
        if (countText != null)
        {
            countText.text = "Score: " + GameManager.instance.GetScore().ToString();
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
