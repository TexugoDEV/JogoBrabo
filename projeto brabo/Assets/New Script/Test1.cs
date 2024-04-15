using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 1;
        do
        {
            Debug.Log(count);
            count++;

        }while (count <= 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
