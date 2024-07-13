using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollower : MonoBehaviour
{
    Transform target;

    void Start() {
        target = PlayerInfo.instance.transform;
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, 3.0f);        
    }
}
