using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Move_Spread : MonoBehaviour
{
    public GameObject g_object1;
    public GameObject g_object2;
    public GameObject g_object3;
    public GameObject g_object4;
    public GameObject g_object5;
    Rigidbody2D rb;
    bool isEnter = false;
    public float speed = 5f;
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
        if (isEnter == true)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(1, 0));
            g_object1.GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0.4f) * speed;
            g_object2.GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0.2f) * speed;
            g_object3.GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;
            g_object4.GetComponent<Rigidbody2D>().velocity = new Vector2(1, -0.2f) * speed;
            g_object5.GetComponent<Rigidbody2D>().velocity = new Vector2(1, -0.4f) * speed;
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
