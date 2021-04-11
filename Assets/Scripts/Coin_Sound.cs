using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Sound : MonoBehaviour
{
    public AudioSource coinSound;
    private bool wasPlay = false;

    // Start is called before the first frame update
    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            if(wasPlay == false)
            {
                coinSound.Play();
                wasPlay = true;
            }
        }
    }
}
