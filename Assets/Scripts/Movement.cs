using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 lastRememberedPosition;

    public Rigidbody rbody;

    public float speed;
    void FixedUpdate()
    {
        Vector3 direction = rbody.transform.forward;
        Vector3 resultForce = direction * speed * Input.GetAxis("Vertical");
        rbody.AddForce(resultForce, ForceMode.Force);
    }
}
