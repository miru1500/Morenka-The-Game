using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Roll_Left : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isEnter = false;
    private bool wasPlay = false;

    [SerializeField]
    private float trapSpeed = 5f;
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private float bounceForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
            if (wasPlay == false)
            {
                audioSource.Play();
                wasPlay = true;
            }
        }
    }
}
