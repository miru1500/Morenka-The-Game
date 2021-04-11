using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBox_Kill_On : MonoBehaviour
{
    public GameObject killCollider;
    public GameObject ground;

    void Start()
    {
        killCollider.gameObject.SetActive(false);
        ground.gameObject.SetActive(true);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.name.Equals("Player"))
        {
            killCollider.gameObject.SetActive(true);
            ground.gameObject.SetActive(false);
        }
    }
}
