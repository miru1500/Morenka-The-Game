using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall_Hidden : MonoBehaviour
{
    public GameObject fireBalls;

    // Start is called before the first frame update
    void Start()
    {
        fireBalls.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        fireBalls.SetActive(true);
    }
}
