using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class LookAtCamera : MonoBehaviour
{
    public Camera arCamera;

    void Update()
    {
        if (arCamera != null)
        {
            transform.LookAt(arCamera.transform);
            transform.Rotate(0, 180, 0);
        }
    }
}
