using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((moveSpeed * Input.GetAxis("Horizontal")) * Time.deltaTime, 0f, (moveSpeed * Input.GetAxis("Vertical")) * Time.deltaTime);
    }
}
