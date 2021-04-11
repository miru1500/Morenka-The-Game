using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Move_Left : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isEnter = false;
    private bool wasPlay = false;

    [SerializeField]
    private float trapSpeed = 5f;
    [SerializeField]
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //This locks the RigidBody so that it does not move or rotate in the z axis (can be seen in Inspector).
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
    }

    void Update()
    {
        if (isEnter == true)
        {
            rb.velocity = new Vector2(-1, 0) * trapSpeed;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            isEnter = true;
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            if (wasPlay == false)
            {
                audioSource.Play();
                wasPlay = true;
            }
        }
    }
}