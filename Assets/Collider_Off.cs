using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Off : MonoBehaviour
{

    public GameObject collider;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            collider.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}