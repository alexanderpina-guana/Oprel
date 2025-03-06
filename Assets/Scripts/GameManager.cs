using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int targetDeathCount = 0;
    public int TargetDeathCount => targetDeathCount;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void RegisterDeath()
    {
        targetDeathCount++;
        Debug.Log("Total:" + targetDeathCount);
    }

    public void UnregisterDeath()
    {
        targetDeathCount = Mathf.Max(0, targetDeathCount -1);
        Debug.Log("Total:" + targetDeathCount);

        if(targetDeathCount == 0)
        {
            WinGame();
        }
    }

    public void WinGame()
    {
        Debug.Log("Success");
    }

    public void LoseGame()
    {
        Debug.Log("Failure");
    }
}
