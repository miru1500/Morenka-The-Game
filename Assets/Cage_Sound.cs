using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cage_Sound : MonoBehaviour
{
    public AudioSource audioSource;
    private bool wasPlay = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("combo"))
        {
            if (wasPlay == false)
            {
                audioSource.Play();
                wasPlay = true;
            }
        }
    }
}
