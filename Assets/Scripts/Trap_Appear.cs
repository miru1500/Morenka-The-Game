using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Appear : MonoBehaviour
{
    public GameObject trapLeft;

    // Start is called before the first frame update
    void Start()
    {
        trapLeft.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Equals("Player"))
        {
            trapLeft.SetActive(true);
        }
    }
}
