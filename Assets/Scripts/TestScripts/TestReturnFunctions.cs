using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestReturnFunctions : MonoBehaviour
{
    [SerializeField]
    private string text;

    // Start is called before the first frame update
    void Start()
    {
        bool testVar = IsAlwaysTrue();

        if (testVar)
        {
            Debug.Log("This is true");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsAlwaysTrue()
    {
        return true;
    }

    public bool IsAlwaysTrue(string additionalMessage)
    {
        Debug.Log(additionalMessage);

        return IsAlwaysTrue();
    }
}
