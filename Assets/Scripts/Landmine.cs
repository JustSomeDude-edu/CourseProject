using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landmine : MonoBehaviour
{
    public float delay = 1.0f; 

    public float damage;
    public float pushbackMult;

    void OnTriggerEnter(Collider other) {
        StartCoroutine(ExplodeWithDelay(delay, other));
    }
    
    private IEnumerator ExplodeWithDelay(float delay, Collider target) {
        yield return new WaitForSeconds(delay);

        Explode(target);
    }

    void Explode(Collider target) {
        if (target.TryGetComponent<Health>(out Health targetHealth)) {
            Vector3 pushbackDirection = (targetHealth.transform.position - transform.position).normalized;
            targetHealth.Damage(damage, pushbackDirection * pushbackMult);
        }
    }

}
