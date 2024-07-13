using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantVelocity : MonoBehaviour
{
    public Vector3 targetVelocity;

    public Rigidbody rbody;

    void Update() {
        rbody.AddForce(targetVelocity - rbody.velocity, ForceMode.VelocityChange);
    }
}
