using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DragRotate : MonoBehaviour
{
    public float rotationSpeed = 0.2f;
    private Vector2 previousTouchPos;

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                float deltaX = touch.deltaPosition.x;
                transform.Rotate(Vector3.up, -deltaX * rotationSpeed, Space.World);
            }
        }
    }
}

