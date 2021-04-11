﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Block_Move : MonoBehaviour
{
    Rigidbody2D rb;
    bool isEnter = false;
    public float forceX = 100;
    public float forceY = 100;
    public AudioSource audioSource;
    private bool wasPlay = false;

    void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
        //This locks the RigidBody so that it does not move or rotate in the z axis (can be seen in Inspector).
        //  rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        rb.AddForce(Vector2.right * forceX);
        rb.AddForce(Vector2.up * forceY);
    }

/*    void Update()
    {
        if (isEnter == true)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(1, 0));
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;
        }
    }*/

    /*void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            isEnter = true;
           // rb.constraints = RigidbodyConstraints2D.None;
           // rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            if (wasPlay == false)
            {
                audioSource.Play();
                wasPlay = true;
            }
        }
    }*/
}
