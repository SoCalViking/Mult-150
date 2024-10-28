using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider rTrigger)
    {
        print(rTrigger.gameObject.name + " has entered the cube");
    }

    void OnTriggerStay (Collider rTrigger)
    {
        print(rTrigger.gameObject.name + " is still in the cube");
    }

    void OnTriggerExit (Collider rTrigger)
    {
        print(rTrigger.gameObject.name + " has left the cube");
    }
}
