using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece_Rotation : MonoBehaviour
{
    public float rotationSpeed = 10f;
    public bool isForward = true;

    void FixedUpdate()
    {
        if (isForward == true)
        {
            transform.Rotate(Vector3.forward * rotationSpeed);
        }
        if (isForward == false)
        {
            transform.Rotate(Vector3.back * rotationSpeed);
        }
    }
}
