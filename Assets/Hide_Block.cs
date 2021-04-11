using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide_Block : MonoBehaviour
{
    public GameObject g_object;

    void Start()
    {
        g_object.SetActive(false);
    }
}
