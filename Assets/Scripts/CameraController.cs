using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Rotational speeds")]
    public float verticalRotationSpeed;
    public float horizontalRotationSpeed;

    [Header("Target Transforms")]
    [SerializeField] private Transform _rotatedXTransform;
    [SerializeField] private Transform _rotatedYTransform;
    void Update() {
        float mouseInputX = Input.GetAxis("Mouse X");
        float mouseInputY = Input.GetAxis("Mouse Y");

        _rotatedXTransform.Rotate(0,
                                   horizontalRotationSpeed * mouseInputX * Time.deltaTime,
                                   0);

        _rotatedYTransform.Rotate(verticalRotationSpeed   * mouseInputY * Time.deltaTime,
                                  0,
                                  0);
    }
}
