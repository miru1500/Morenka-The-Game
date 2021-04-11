using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Effect : MonoBehaviour
{
    public AudioSource audioSource;
    private bool wasPlay = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            if (wasPlay == false)
            {
                audioSource.Play();
                wasPlay = true;
            }
        }
    }
}
