using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerWASD : MonoBehaviour
{
    public float speed;
    public void Move(float vertical, float horizontal) {
        Vector3 direction = new Vector3(vertical, 0, horizontal);
        transform.position += direction * speed * Time.deltaTime;
    }
}
