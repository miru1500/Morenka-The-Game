using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide_Player : MonoBehaviour
{
    public GameObject player;
    Rigidbody2D rb;
    public float forceX;
    public float forceY;

    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            rb.AddForce(Vector2.up * forceY);
            rb.AddForce(Vector2.right * forceX);
        }
    }
}
