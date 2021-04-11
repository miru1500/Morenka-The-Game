using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidden_Boxes_Appear : MonoBehaviour
{
    public GameObject hiddenBoxes;

    // Start is called before the first frame update
    void Start()
    {
        hiddenBoxes.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Equals("Player"))
        {
            hiddenBoxes.SetActive(true);
        }
    }
}
