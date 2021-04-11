using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Hidden : MonoBehaviour
{
    public GameObject trapLeft;

    // Start is called before the first frame update
    void Start()
    {
        trapLeft.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Equals("Player"))
        {
            trapLeft.SetActive(false);
        }
    }
}
