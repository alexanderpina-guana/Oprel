using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Death : MonoBehaviour
{

    // Update is called once per frame
    public virtual void Update()
    {
        
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
}
