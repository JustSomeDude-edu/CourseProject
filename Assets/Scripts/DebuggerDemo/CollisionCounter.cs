using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCounter : MonoBehaviour
{
    private int counter = 0;
    void OnCollisionEnter(Collision other) {
        counter ++;
    }
}
