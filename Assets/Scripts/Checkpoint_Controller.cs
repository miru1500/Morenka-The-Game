using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint_Controller : MonoBehaviour
{
    private GameMaster gm;
    public GameObject checkpointSprite;

    void Start()
    {
        checkpointSprite.SetActive(true);
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag.Equals("Player"))
        {
            checkpointSprite.SetActive(false);
            gm.lastCheckPointPos = transform.position;
        }
    }
}
