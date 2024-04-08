using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = -10;

        if (number > 0)
        {
            Debug.Log("o numero é maior que 0");
        }
        else
        {
            Debug.Log("o numero não é maior que 0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
