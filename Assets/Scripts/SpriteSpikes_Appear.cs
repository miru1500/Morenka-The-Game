using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSpikes_Appear : MonoBehaviour
{
    public GameObject spriteSpikes;

    // Start is called before the first frame update
    void Start()
    {
        spriteSpikes.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag.Equals("Player"))
        {
            spriteSpikes.SetActive(true);
        }
    }
}
