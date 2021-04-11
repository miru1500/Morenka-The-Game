using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question_Trigger : MonoBehaviour
{
    private bool wasPlay = false;

    [SerializeField]
    private GameObject g_object;
    [SerializeField]
    private AudioSource effect;

    // Start is called before the first frame update
    void Start()
    {
        g_object.SetActive(false);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            g_object.gameObject.SetActive(true);
            if (wasPlay == false)
            {
                effect.Play();
                wasPlay = true;
            }
        }
    }
}
