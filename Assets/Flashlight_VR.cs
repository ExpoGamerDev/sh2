using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight_VR : MonoBehaviour
{
    public GameObject flashLight;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            flashLight.SetActive(true);
        }
        if(OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            flashLight.SetActive(false);
        }
    }
}
