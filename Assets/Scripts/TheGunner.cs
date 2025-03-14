using UnityEngine;

public class TheGunner : MonoBehaviour
{
    public KeyCode shoot;
    //For shooting
    public GameObject green_body_circle;

    //For Audio
    public AudioClip hurtSound;
    public float soundVolume = 1.0f;
    private AudioSource audioSource;

      void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if(audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.spatialBlend = 1.0f;
        audioSource.minDistance = 1f;
        audioSource.maxDistance = 50f;
        audioSource.rolloffMode = AudioRolloffMode.Linear;
    }

    void Update()
    {
        Transform tf = transform;

        //Shooting Input
        if (Input.GetKeyDown(shoot))
        {
        //play sound
            if (hurtSound != null && audioSource != null)
            {
                audioSource.transform.position = transform.position;
                audioSource.PlayOneShot(hurtSound, soundVolume);
            }
            
            //Spawn Bullet
            Vector3 spawnPosition = transform.position + transform.up * 2f;

            //Firing
            Instantiate(green_body_circle, spawnPosition, transform.rotation);
        }
    }
}
