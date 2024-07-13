using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogDamage : MonoBehaviour
{
    public void logDamage(float damage, Vector3 pushback) {
        Debug.Log("Got damaged! " + damage);
    }
}
