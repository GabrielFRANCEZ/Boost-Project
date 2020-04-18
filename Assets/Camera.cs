using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Transform camTransform;
    Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        camTransform = GetComponent(typeof(Transform)) as Transform;
        originalPos = camTransform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Shake();
    }

    void Shake ()
    {
        if (Input.GetKey(KeyCode.Space)|| Input.GetKey(KeyCode.Z))
        {
            camTransform.localPosition = originalPos + UnityEngine.Random.insideUnitSphere * 0.05f;
        }
        else
        {
            camTransform.localPosition = originalPos;
        }
    }
}
