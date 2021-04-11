using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes_Appear : MonoBehaviour
{
    public GameObject spikes;
    // Start is called before the first frame update
    void Start()
    {
        spikes.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            spikes.gameObject.SetActive(true);
        }
    }
	
	void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            spikes.SetActive(true);
        }
    }
}
