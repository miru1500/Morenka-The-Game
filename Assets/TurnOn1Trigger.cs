using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn1Trigger : MonoBehaviour
{
    public GameObject trig_object;
    public GameObject kill_object;

    // Start is called before the first frame update
    void Start()
    {
        trig_object.SetActive(false);
        kill_object.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            trig_object.SetActive(true);
            kill_object.SetActive(true);
        }
    }
}
