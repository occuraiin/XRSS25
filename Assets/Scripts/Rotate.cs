using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Rotate : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 10f * Time.deltaTime, 0);
    }
}
