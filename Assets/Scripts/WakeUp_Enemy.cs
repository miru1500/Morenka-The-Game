using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp_Enemy : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag.Equals("Player"))
        {
            enemy.gameObject.SetActive(true);
        }
    }
}
