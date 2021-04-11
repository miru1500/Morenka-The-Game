using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo_Trigger : MonoBehaviour
{
    public GameObject trap;

    // Start is called before the first frame update
    void Start()
    {
        trap.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name.Equals("Player"))
        {
            trap.SetActive(true);
        }
    }
}
