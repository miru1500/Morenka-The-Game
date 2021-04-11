using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_Appear : MonoBehaviour
{
    public GameObject cloud;

    // Start is called before the first frame update
    void Start()
    {
        cloud.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Equals("Player"))
        {
            cloud.SetActive(true);
        }
    }
}
