using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Disappear : MonoBehaviour
{
    public GameObject trig_object;

    void Start()
    {
        trig_object.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Equals("Player"))
        {
            trig_object.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            trig_object.SetActive(false);
        }
    }
}
