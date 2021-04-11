using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q_Trigger : MonoBehaviour
{
    public GameObject trapBoxCoin;
    public AudioSource effect;
    private bool wasPlay = false;
    // Start is called before the first frame update
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            trapBoxCoin.gameObject.SetActive(false);
            if (wasPlay == false)
            {
                effect.Play();
                wasPlay = true;
            }
        }
    }
}
