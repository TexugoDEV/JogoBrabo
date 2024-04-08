using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresComparativos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        int b = 20;

        bool comp1 = a > b;

        Debug.Log("A > B" + comp1);

        bool comp2 = a < b;

        Debug.Log("a < b" + comp2);

        bool comp3 = a >= b;

        Debug.Log("a => b" + comp3);

        bool comp4 = a <= b;

        Debug.Log("b <= a" + comp4);

        bool comp5 = a == b;

        Debug.Log("a == b" + comp5);

        bool comp6 = a != b;

        Debug.Log("a != b" + comp6);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
