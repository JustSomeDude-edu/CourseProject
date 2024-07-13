using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnKeyboardWASD : MonoBehaviour
{
    public OnWASDEvent WASDevent;

    void Update() {
        WASDevent.Invoke(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
    }
}

[System.Serializable]
public class OnWASDEvent : UnityEvent <float, float> {};
