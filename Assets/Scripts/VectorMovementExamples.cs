using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMovementExamples : MonoBehaviour
{
    public float speed;

    private Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Has position change at a 45 degree angle (1, 1, 0) in local space
        // tf.position = tf.position + tf.TransformDirection(new Vector3(1, 1, 0)) * speed;
        //tf.Translate(Vector3.up, Space.World); // Relative movement up (in world space)
        tf.Translate(Vector3.up, Space.Self); // Relative movement up in local space
    }
}
