using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a;
        a = 2;
        int b;
        b = 4;
        int c;
        c = 8;
        int sum;
        sum = 14;
        sum = sum += 1;
        
        Debug.Log("sum is " + sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
