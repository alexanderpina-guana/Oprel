using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //score
    public int score = 0;

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

      private void Start()
    {
        score = 0;
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

     public void AddScore(int addedScore)
    {
        score += addedScore;
    }

    public int GetScore()
    {
        return score;
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
