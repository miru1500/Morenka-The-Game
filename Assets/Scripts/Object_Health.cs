using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Health : MonoBehaviour
{
    /*void Update()
    {
        if(gameObject.transform.position.y < -10 || gameObject.transform.position.y > 8 || gameObject.transform.position.x < 0)
        {
            Destroy(gameObject);
        }
    }*/

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("destroy"))
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("destroy"))
        {
            Destroy(gameObject);
        }
    }
}
