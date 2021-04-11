using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{

    void Update()
    {
        if(gameObject.transform.position.y < -10 || gameObject.transform.position.y > 15 || gameObject.transform.position.x < 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag.Equals("Player") || col.gameObject.tag.Equals("destroyEnemy"))
        {
            Destroy(gameObject);
        }
    }
}
