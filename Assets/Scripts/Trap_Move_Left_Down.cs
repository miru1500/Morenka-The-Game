using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Move_Left_Down : MonoBehaviour
{
    Rigidbody2D rb;
    bool isEnter = false;
    public float trapSpeed = 5f;
    public AudioSource audioSource;
    private bool wasPlay = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //This locks the RigidBody so that it does not move or rotate in the z axis (can be seen in Inspector).
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
    }

    void Update()
    {
        if(isEnter == true)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-1, -1) * trapSpeed;
        }
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.name.Equals("Player"))
        {
            isEnter = true;
            rb.constraints = RigidbodyConstraints2D.None;
            if(wasPlay == false)
            {
                audioSource.Play();
                wasPlay = true;
            }
        }
    }
}
