using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rbody;

    public float acceleration;
    public float maxSpeed;
    void FixedUpdate()
    {
        Vector3 directionForward = rbody.transform.forward * Input.GetAxis("Vertical");
        Vector3 directionRight =   rbody.transform.right   * Input.GetAxis("Horizontal");
        Vector3 result = (directionForward + directionRight).normalized;
        if (rbody.velocity.magnitude < maxSpeed)
            rbody.AddForce(result * acceleration, ForceMode.Acceleration);
        Debug.Log(rbody.velocity.magnitude);
    }
}
