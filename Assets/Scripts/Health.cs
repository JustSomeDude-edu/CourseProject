using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public UnityFloatVectorEvent onDamaged;

    public void Damage(float damage, Vector3 knockback) {
        onDamaged.Invoke(damage, knockback);
    }

    public void Update() {
        Debug.Log("Some Logic");
    }
}

[System.Serializable]
public class UnityFloatVectorEvent : UnityEvent <float, Vector3> {}