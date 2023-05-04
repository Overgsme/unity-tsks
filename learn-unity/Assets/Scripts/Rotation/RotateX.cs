using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateX : MonoBehaviour
{
    public float speed = 10;
    void FixedUpdate()
    {
        transform.Rotate(Time.deltaTime*speed, 0, 0);
    }
}
