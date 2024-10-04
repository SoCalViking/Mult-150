using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int Number = 21;
        int X = 1;
        while (Number <= 100)
        {
            Number += X;
            Debug.Log(Number);
            Number++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
