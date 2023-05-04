using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateZ : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
