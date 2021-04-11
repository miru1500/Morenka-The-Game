using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Appear : MonoBehaviour
{
    public AudioSource coinSound;
    private bool wasPlay = false;
    public GameObject box;

    void Start()
    {
        box.SetActive(false);
    }

    // Start is called before the first frame update
    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            box.SetActive(true);
            if(wasPlay == false)
            {
                coinSound.Play();
                wasPlay = true;
            }
        }
    }
}
