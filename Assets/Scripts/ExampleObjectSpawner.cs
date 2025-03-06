using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleObjectSpawner : MonoBehaviour
{
    public GameObject pf;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newObject = Instantiate(pf, GetComponent<Transform>().position, GetComponent<Transform>().rotation) as GameObject;

        // if it instantiated correctly
        if (newObject != null)
        {
            // Grab its movement component
            BulletMovement newBM = newObject.GetComponent<BulletMovement>();

            // If we successfully got the component
            if (newBM != null)
            {
                // Set the force property of that component to a new value
                newBM.force = 700;
            }
        }

        // Destroy bullet if it persists after a certain period of time (ideally stored in a public variable)
        Destroy(newObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
