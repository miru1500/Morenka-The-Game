using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Trigger : MonoBehaviour
{
    public AudioSource soundJumper;
    private bool wasPlay = false;
    public bool czyJestWysoko = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Equals("Player") && wasPlay == false)
        {
            soundJumper.Play();
            wasPlay = true;
            czyJestWysoko = true;
        }
    }
}
