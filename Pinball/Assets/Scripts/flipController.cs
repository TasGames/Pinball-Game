using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipController : MonoBehaviour 
{
    protected Rigidbody2D rightFlipperRigid;
    protected Rigidbody2D leftFlipperRigid;
    [SerializeField] protected GameObject rightFlipper;
    [SerializeField] protected GameObject leftFlipper;
    [SerializeField] protected float torqueForce;

    protected float torqueForceL;
    protected float torqueForceR;

    void Start()
    {
        rightFlipperRigid = rightFlipper.GetComponent<Rigidbody2D>();
        leftFlipperRigid = leftFlipper.GetComponent<Rigidbody2D>();

        torqueForceR = torqueForce * -1;
        torqueForceL = torqueForce;
    }

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.touchCount == 1)
            {
                var touch = Input.touches[0];

                if (touch.position.x > Screen.width / 2 && touch.position.y < Screen.height / 5)
                    rightFlipperRigid.AddTorque(torqueForceR);
                else if (touch.position.x < Screen.width / 2 && touch.position.y < Screen.height / 5)
                    leftFlipperRigid.AddTorque(torqueForceL);
            }
        }
        else
        {
            if (Input.GetKey("d"))
                rightFlipperRigid.AddTorque(torqueForceR);
            else if (Input.GetKey("a"))
                leftFlipperRigid.AddTorque(torqueForceL);
        }
    }
}
