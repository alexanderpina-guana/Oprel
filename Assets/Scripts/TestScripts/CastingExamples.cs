using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingExamples : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int integerNum = 4;
        float floatNum = 3.4f;

        integerNum = (int)floatNum;

        Debug.Log(integerNum);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
