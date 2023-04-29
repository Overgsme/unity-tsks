using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFull : MonoBehaviour
{
    public float speed = 10;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);
    }
}
