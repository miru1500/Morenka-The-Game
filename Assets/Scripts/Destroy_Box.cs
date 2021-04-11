﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Box : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
        }
    }
}
