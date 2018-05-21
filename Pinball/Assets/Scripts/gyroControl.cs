using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroControl : MonoBehaviour
{
    public float movement;
    protected Rigidbody ballRb;

    void Start ()
    {
        ballRb = GetComponent<Rigidbody>();
    }
	
	void Update ()
    {
        Input.gyro.enabled = true;
        float horizontal = Input.gyro.rotationRateUnbiased.y * movement;
        transform.Translate(horizontal, 0, 0);

        float vertical = -Input.gyro.rotationRateUnbiased.x * movement;
        transform.Translate(0, vertical, 0);
    }
}
