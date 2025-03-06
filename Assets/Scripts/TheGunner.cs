using UnityEngine;

public class TheGunner : MonoBehaviour
{
    public KeyCode shoot;
    //For shooting
    public GameObject green_body_circle;

    void Update()
    {
        Transform tf = transform;

        //Shooting Input
        if (Input.GetKeyDown(shoot))
        {
            //Spawn Bullet
            Vector3 spawnPosition = transform.position + transform.up * 2f;

            //Firing
            Instantiate(green_body_circle, spawnPosition, transform.rotation);
        }
    }
}
