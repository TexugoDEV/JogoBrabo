using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int IntegerExample = 100;
        float FloatExample = 1.5f;
        double DoubleExample = 10.100;
        bool BoolExample = true;//false
        string StringExample = "eae gay";

        Debug.Log("Integer:" + IntegerExample);
        Debug.Log("Float:" + FloatExample);
        Debug.Log("Double:" + DoubleExample);
        Debug.Log("Boll:" + BoolExample);
        Debug.Log("String:" + StringExample);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
