using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug_test : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Dotykanko");
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Nie Dotykanko");
        }
    }
}
