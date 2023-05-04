using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SkateboardController : MonoBehaviour
{
    public float maxMotorTorque; // maximum torque the motor can apply to wheel
    public float maxSteeringAngle; // maximum steer angle the wheel can have

    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void FixedUpdate()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        transform.Rotate(0,steering,0);
        var dir = transform.TransformDirection(Vector3.left);
        rb.AddForce(dir*motor,ForceMode.Force);
        
    }
}
