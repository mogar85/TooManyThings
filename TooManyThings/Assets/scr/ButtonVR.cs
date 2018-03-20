using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    [SerializeField]
    OVRInput.Button inputPress;

    [SerializeField]
    UnityEvent action;

    private void OnTriggerStay(Collider other)
    {
        print("Triggered!");
        if (OVRInput.Get(inputPress))
        {
            action.Invoke();
        }
    }
}
