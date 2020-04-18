using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidBody;
    AudioSource rocketMotorSound;

    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rocketMotorSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        Thrust();
        Rotate();
    }

    private void Rotate()
    {
        //manual control of rotation
        rigidBody.freezeRotation = true;
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward);
        }
        //resume physics control
        rigidBody.freezeRotation = false;
    }

    private void Thrust()
    {
        if (Input.GetKey(KeyCode.Space)|| Input.GetKey(KeyCode.Z))
        {
            rigidBody.AddRelativeForce(Vector3.up);

            if (!rocketMotorSound.isPlaying)
            {
                rocketMotorSound.Play();
            }
        }
        else
        {
            rocketMotorSound.Stop();
        }
    }
}
