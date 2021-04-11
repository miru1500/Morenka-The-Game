using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Appear : MonoBehaviour
{
    public GameObject trig_object;

    void Start()
    {
        trig_object.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            trig_object.SetActive(true);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            trig_object.SetActive(true);
        }
    }
}
