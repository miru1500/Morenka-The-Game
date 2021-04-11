using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBox_Trap : MonoBehaviour
{
    public GameObject coinBoxTrap;

    void Start()
    {
        coinBoxTrap.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        coinBoxTrap.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        coinBoxTrap.SetActive(false);
    }
}
