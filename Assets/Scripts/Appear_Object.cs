using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear_Object : MonoBehaviour
{
    public GameObject g_object;

    void Start()
    {
        g_object.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Equals("Player"))
        {
            g_object.SetActive(true);
        }
    }
}
