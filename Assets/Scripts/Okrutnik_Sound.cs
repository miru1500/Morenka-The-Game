using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Okrutnik_Sound : MonoBehaviour
{
    public AudioSource okrutnikSound;
    private bool wasPlay = false;

    // Start is called before the first frame update
    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            if(wasPlay == false)
            {
                okrutnikSound.Play();
                wasPlay = true;
            }
        }
    }
}
