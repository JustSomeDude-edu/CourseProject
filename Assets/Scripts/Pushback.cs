using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushback : MonoBehaviour
{
    public Rigidbody rbody;
    public Health health;

    public void InflictPushback(float damage, Vector3 pushbackForce) {
        Debug.Log("Inflicted Pushback");
        rbody.AddForce(pushbackForce, ForceMode.Impulse);
    }

    void OnEnable() {
        health.onDamaged.AddListener(InflictPushback);
    }

    void OnDisable() {
        health.onDamaged.RemoveListener(InflictPushback);
    }
}
