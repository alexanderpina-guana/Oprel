using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float force;
    private Transform tf;
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        rb2D = GetComponent<Rigidbody2D>();

        rb2D.AddForce(tf.right * force);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * force * Time.deltaTime);
    }
}
