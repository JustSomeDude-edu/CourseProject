using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public static PlayerInfo instance;
    // Start is called before the first frame update
    void OnEnable()
    {
        instance = this;
    }
}
