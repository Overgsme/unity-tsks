using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneHoldedObject : MonoBehaviour
{
    public GameObject plane;
    Vector3 min;
    Vector3 max;
    private void Start()
    {
        var r = plane.GetComponent<Renderer>();
        min = r.bounds.min;
        max = r.bounds.max;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.x > max.x)
        {
            var r = GetComponent<Rigidbody>();
            r.velocity = new Vector3(-r.velocity.x,r.velocity.y+0.1f,r.velocity.z);
            transform.position.Set(max.x,transform.position.y,transform.position.z);
            Debug.Log("Hit plane border");
        }
        if (transform.position.z > max.z)
        {
            var r = GetComponent<Rigidbody>();
            r.velocity = new Vector3(r.velocity.x, r.velocity.y+0.1f, -r.velocity.z);
            transform.position.Set(transform.position.x, transform.position.y, max.z);

            Debug.Log("Hit plane border");
        }
        if (transform.position.x < min.x)
        {
            var r = GetComponent<Rigidbody>();
            r.velocity = new Vector3(-r.velocity.x, r.velocity.y + 0.1f, r.velocity.z);
            transform.position.Set(min.x, transform.position.y, transform.position.z);
            Debug.Log("Hit plane border");
        }
        if (transform.position.z < min.z)
        {
            var r = GetComponent<Rigidbody>();
            r.velocity = new Vector3(r.velocity.x, r.velocity.y + 0.1f, -r.velocity.z);
            transform.position.Set(transform.position.x, transform.position.y, min.z);
            Debug.Log("Hit plane border");
        }
    }
}
