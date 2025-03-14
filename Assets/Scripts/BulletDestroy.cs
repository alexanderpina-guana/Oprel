using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{

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
    private void OnCollisionEnter2D(Collision2D collision)
    {
     if(hurtSound != null)
        {
            audioSource.transform.position = transform.position;

            audioSource.PlayOneShot(hurtSound);
        }
        
        // Destroys other object
        Destroy(collision.gameObject);
        // Destroys itself
        Destroy(gameObject);
    }
}
