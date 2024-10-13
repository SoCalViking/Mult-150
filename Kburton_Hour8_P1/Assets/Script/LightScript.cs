using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public bool enabled pauseMenu;

    public void Start()
    {
        //Enables the pause menu UI.
        pauseMenu.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
            print("The 'L' key is pressed down");
    }
}
