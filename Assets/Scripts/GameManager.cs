using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //score
    public int score = 0;

    private int targetDeathCount = 0;
    public int TargetDeathCount => targetDeathCount;

    //For Audio
    public AudioMixer audioMixer;

    //For Volume Sliders
    public Slider mainVolumeSlider;
    public Slider musicVolumeSlider;
    public Slider sfxVolumeSlider;
   

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

        //Setting volumes
        LoadVolumeSettings();

        //Add Listeners
        mainVolumeSlider.onValueChanged.AddListener(UpdateMainVolume);
        musicVolumeSlider.onValueChanged.AddListener(UpdateMusicVolume);
        sfxVolumeSlider.onValueChanged.AddListener(UpdateSFXVolume);
    }


    private void LoadVolumeSettings()
    {
        float mainVolume = PlayerPrefs.GetFloat("MainVolume", .5f);
        float musicVolume = PlayerPrefs.GetFloat("MusicVolume", .5f);
        float sfxVolume = PlayerPrefs.GetFloat("SFXVolume", .5f);

        mainVolumeSlider.value = Mathf.Pow(10, mainVolume / 20);
        musicVolumeSlider.value = Mathf.Pow(10, musicVolume / 20);
        sfxVolumeSlider.value = Mathf.Pow(10, sfxVolume / 20);
    }

    private void UpdateMainVolume(float value)
    {
        audioMixer.SetFloat("MainVolume", Mathf.Log10(value) * 20);
        PlayerPrefs.SetFloat("MainVolume", value);
    }

    private void UpdateMusicVolume(float value)
    {
        audioMixer.SetFloat("MusicVolume", Mathf.Log10(value) * 20);
        PlayerPrefs.SetFloat("MusicVolume", value);
    }

        private void UpdateSFXVolume(float value)
    {
        audioMixer.SetFloat("SFXVolume", Mathf.Log10(value) * 20);
        PlayerPrefs.SetFloat("SFXVolume", value);
    }

    private void SetInitialSliderValues()
    {
        float mainVolume, musicVolume, sfxVolume;
        audioMixer.GetFloat("MainVolume", out mainVolume);
        audioMixer.GetFloat("MusicVolume", out musicVolume);
        audioMixer.GetFloat("SFXVolume", out sfxVolume);

        mainVolumeSlider.value = Mathf.Pow(10, mainVolume / 20);
        musicVolumeSlider.value = Mathf.Pow(10, musicVolume / 20);
        sfxVolumeSlider.value = Mathf.Pow(10, sfxVolume / 20);
    }

    private void UpdateMainVolumeWithDB(float value)
    {
        audioMixer.SetFloat("MainVolume",Mathf.Log10(value)* 20);
    }

    private void UpdateMusicVolumeWithDB(float value)
    {
        audioMixer.SetFloat("MusicVolume", Mathf.Log10(value) * 20);
    }

    private void UpdateSFXVolumeWithDB(float value)
    {
        audioMixer.SetFloat("SFXVolume", Mathf.Log10(value) * value);
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
