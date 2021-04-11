using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall_Rotation : MonoBehaviour
{
    
   Rigidbody2D rb;
   public float rotationSpeed = 7;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //This locks the RigidBody so that it does not move or rotate in the z axis (can be seen in Inspector).
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        rb.rotation = 1f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.rotation = rb.rotation + rotationSpeed;
    }
}
