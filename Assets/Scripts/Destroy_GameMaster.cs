﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_GameMaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy (GameObject.Find("GameMaster"));
        Destroy (GameObject.Find("LiveMaster"));
    }
}
