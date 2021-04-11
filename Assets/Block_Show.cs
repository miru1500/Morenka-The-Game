using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Show : MonoBehaviour
{
    public GameObject g_object;
    public GameObject trigOn_object;
    public GameObject trigOff_object;
    void Start()
    {
        g_object.SetActive(false);
        trigOn_object.SetActive(true);
        trigOff_object.SetActive(true);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            trigOn_object.SetActive(false);
            trigOff_object.SetActive(false);
            g_object.SetActive(true);
        }
    }
}
