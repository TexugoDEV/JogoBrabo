using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        int b = 20;
        int c = 30;

        //AND ou &

        bool result1 = (a < b) && (b < c);
        Debug.Log(result1);

        //OR ou ||

        bool result2 = (a > b) || (b < c);
        Debug.Log(result2);

        //AND ou OR
        //                    true        true
        bool result3 = (a < b) && (c > b) || (a == 10);
        Debug.Log(result3);

        //NOT ou !
        bool result4 = !(a > b);
        Debug.Log(result4);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
