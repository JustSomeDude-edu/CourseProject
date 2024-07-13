using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dodge : MonoBehaviour
{
    [SerializeField, Tooltip("Chance to dodge an enemy attack"), Range(0.0f, 1.0f)] 
    private float _dodgeChance;

    public Movement movement;

    void Start() {
        movement.lastRememberedPosition = Vector3.up;
    }
}
