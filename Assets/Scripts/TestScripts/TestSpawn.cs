using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawn : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject spawnedBullet = Instantiate(prefab, Vector3.zero, Quaternion.identity);

        spawnedBullet.GetComponent<BulletMovement>().force = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
