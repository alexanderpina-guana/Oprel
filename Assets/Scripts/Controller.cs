using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Mover mover;

    public float speed;
    public float turnSpeed;

    public KeyCode moveUp;
    public KeyCode moveDown;
    public KeyCode moveLeft;
    public KeyCode moveRight;

    // This will store the value Shift
    public KeyCode incrementalMovementEnable;

    public KeyCode resetPosition;

    public KeyCode toggleMovement;

    public KeyCode disableSpriteGameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //so the arrow move the object
        float arrowX = 0f;
        float arrowY = 0f;

        //Detects the keys
        if(Input.GetKey(KeyCode.UpArrow))
        {
            arrowY = 1f;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            arrowY = -1f;
        }
         if(Input.GetKey(KeyCode.LeftArrow))
        {
            arrowX = -1f;
        }
         if(Input.GetKey(KeyCode.RightArrow))
        {
            arrowX = 1f;
        }

        //for movement
        Vector2 movePosition = new Vector2(arrowX, arrowY).normalized;
        transform.position +=(Vector3)movePosition * speed * Time.deltaTime;

        //Other Options
        if (Input.GetKeyDown(disableSpriteGameObject))
        {
            gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(toggleMovement))
        {
            mover.enabled = !mover.enabled;
        }

        if (Input.GetKeyDown(resetPosition))
        {
            // Reset position
            mover.ResetPosition();
        }

        if (!Input.GetKey(incrementalMovementEnable))
        {
            if (Input.GetKey(moveUp))
            {
                // Move up
                mover.MoveUp(speed);
            }
            if (Input.GetKey(moveDown))
            {
                // Move down
                mover.MoveDown(speed);
            }
            if (Input.GetKey(moveLeft))
            {
                // Move left
                mover.RotateClockwise(turnSpeed);
            }
            if (Input.GetKey(moveRight))
            {
                // Move right
                mover.RotateCounterclockwise(turnSpeed);
            }
        }
        else if (Input.GetKey(incrementalMovementEnable))
        {
            if (Input.GetKeyDown(moveUp))
            {
                // Move up 1 meter increment
                mover.MoveUp(1);
            }
            if (Input.GetKeyDown(moveDown))
            {
                // Move down 1 meter increment
                mover.MoveDown(1);
            }/*
            if (Input.GetKeyDown(moveLeft))
            {
                // Move left 1 meter increment
                mover.MoveLeft(1);
            }
            if (Input.GetKeyDown(moveRight))
            {
                // Move right increment
                mover.MoveRight(1);
            }*/
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("The GameObject of the other object is named: " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb2D = collision.gameObject.GetComponent<Rigidbody2D>();

        if (rb2D != null)
        {
            Debug.Log("The X position of the other object's transform is: " + rb2D.name);
            GameManager.instance.LoseGame();
        }
        else
        {
            Debug.Log("Rigidbody2D does not exist on GameObject");
        }
    }
}
