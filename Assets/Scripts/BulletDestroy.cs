using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Destroys other object
        Destroy(collision.gameObject);
        // Destroys itself
        Destroy(gameObject);
    }
}
