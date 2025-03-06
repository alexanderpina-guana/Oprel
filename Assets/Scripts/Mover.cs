using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Transform tf;
    private Rigidbody2D rb2D;
    //Movements and Keypresses set
    public KeyCode keyPress;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

   


    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    //For teleporting the sprite
        if (Input.GetKeyDown(keyPress))
        {
            Vector3 position = new Vector3(Random.Range(xMin, xMax),Random.Range(yMin, yMax), 0);
            transform.SetPositionAndRotation(position, Quaternion.identity);
        }
    }

    public void MoveUp(float speedInput)
    {
        // Move up every frame draw by adding something to the Y of our position
        //tf.position = tf.position + (tf.right * speedInput);
        rb2D.AddForce(tf.right * speedInput);
    }

    public void MoveDown(float speedInput)
    {
        //tf.position = tf.position + (tf.right * -speedInput);
        rb2D.AddForce(tf.right * -speedInput);
    }

    public void RotateClockwise(float turnSpeed)
    {
        tf.Rotate(0, 0, turnSpeed);
    }

    public void RotateCounterclockwise(float turnSpeed)
    {
        tf.Rotate(0, 0, -turnSpeed);
    }

    public void ResetPosition()
    {
        // Resets our position back to the world's origin
        tf.position = Vector3.zero;
    }
}
