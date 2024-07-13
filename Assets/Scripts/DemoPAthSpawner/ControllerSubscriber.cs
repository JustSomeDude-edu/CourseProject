using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSubscriber : MonoBehaviour
{
    public ControllerWASD controller;
    public OnKeyboardWASD eventController;
    public KeyCode toggleKey;
    bool isToggled = false;

    void Update() {
        if (Input.GetKeyDown(toggleKey)) {
            if (!isToggled) {
                eventController.WASDevent.AddListener(controller.Move);
            } else {
                eventController.WASDevent.RemoveListener(controller.Move);
            }
            isToggled = !isToggled;
        }
    }
}
