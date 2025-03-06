using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomExample : MonoBehaviour
{
    public Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        // find a random point within a circle with radius 1 (from the origin)
        Vector3 randomVector = Random.insideUnitCircle;

        // stretch the vector to that point so it is now (up to) 10 units away from the origin
        randomVector *= 10;

        // Add that vector to our position -- so we are now (up to) 10 units away from our current position
        Vector3 newPosition = tf.position + randomVector; // Note: if you add a Vector2 to a Vector3, only X and Y components change

        // Move to that point
        tf.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
