using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private Light myLight;

    private void Start()
    {
        myLight = this.GetComponent<Light>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
