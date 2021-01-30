using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnAwake : MonoBehaviour
{
    void Awake()
    {
        this.gameObject.active = true;
    }
}
