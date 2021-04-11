using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Disappear : MonoBehaviour
{
    public GameObject objectGood;

    void Start()
    {
        objectGood.SetActive(true);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag.Equals("Player"))
        {
            objectGood.SetActive(false);
        }
    }
}
