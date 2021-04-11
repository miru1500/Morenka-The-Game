using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Disappear : MonoBehaviour
{
    public GameObject coin;

    void Start()
    {
        coin.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("CoinDestroy"))
        {
            coin.SetActive(false);
        }
    }
}
