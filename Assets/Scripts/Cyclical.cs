using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyclical : MonoBehaviour
{
    public float cycleLength = 3;

    public void Logic() {
        Debug.Log("CyclePassed! " + Time.time);
    }

    private IEnumerator CyclicalLogic(float cycleLength) {
        yield return new WaitForSeconds(cycleLength);
        Logic();
        StartCoroutine(CyclicalLogic(cycleLength));
        Debug.Log("DoubleCycled " + Time.time);
    }

    void Start() {
        StartCoroutine(CyclicalLogic(cycleLength));
    }
}
