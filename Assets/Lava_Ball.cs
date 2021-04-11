using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava_Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private bool isFacingUp;

    [SerializeField]
    private GameObject g_object;
    [SerializeField]
    private float bounceForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (rb.velocity.y >= 0)
        {
            if (isFacingUp == true)
            {
                transform.Rotate(new Vector3(0, 0, 180));
                isFacingUp = false;
            }
            //sr.flipY = false;
        }
        else
        {
            if (isFacingUp == false)
            {
                transform.Rotate(new Vector3(0, 0, 180));
                isFacingUp = true;
            }
            //sr.flipY = true;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("LavaBallBouncer"))
        {
            rb.velocity = Vector2.up * bounceForce;
        }
    }
}
