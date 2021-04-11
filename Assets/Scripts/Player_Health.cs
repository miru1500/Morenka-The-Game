using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{
   
  //  public GameObject livesObject;
    private GameMaster gm;
  //  public bool hasDied;
  //  public bool hasJumperDied;
    private bool isRepeat = false;
  //  public GameObject YouDied;
  //  public AudioSource dead;
  //  public AudioSource jumperDead;
    private bool wasPlay = false;
   // public GameObject jumperSound;
  //  private int i = 1;
   // public GameObject livesText;
   // public GameObject blackGround;
  //  public Animator animator;


    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    //    Lives lives = livesObject.GetComponent<Lives>();
     //   StartCoroutine("ShowLives");
     //   hasDied = false;
     //   YouDied.gameObject.SetActive(false);
    //    Lives livesPlayer = livesObject.GetComponent<Lives>();
    //    Debug.Log("Lives: " + Lives.livesPlayer);
     //   i = 1;
    }

    void Update()
    {
      
    }
    void OnTriggerEnter2D (Collider2D col)
    {
       
    }

   
   

}
