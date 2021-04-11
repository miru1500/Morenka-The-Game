using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    public int EnemySpeed;
    public int XMoveDirection;
    Rigidbody2D rb;
    private bool facingRight = true;
    public bool hasDied;
    private bool isRepeat = false;
    public GameObject YouDied;
    public AudioSource dead;
    private bool wasPlay = false;


    void Start()
    {
     //   Time.timeScale = 1;
        hasDied = false;
        YouDied.gameObject.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
        //This locks the RigidBody so that it does not move or rotate in the z axis (can be seen in Inspector).
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(XMoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XMoveDirection, 1) * EnemySpeed;
        if(hit.distance<0.4f && hit.collider.tag != "coin" && hit.collider.tag != "kill" && hit.collider.tag != "wakeUp" && hit.collider.tag != "border" && hit.collider.tag != "ignore")
        {
            Flip();
            /*if(hit.collider.tag == "Player")
            {
               // Destroy(hit.collider.gameObject);
                hasDied = true;
            }
        }
        if(hasDied == true)
        {
            StartCoroutine("Die");
        }*/
        }
    }
/*
    IEnumerator Die()
    {
        if(isRepeat == false)
        {
            Debug.Log("Player upad");
            YouDied.gameObject.SetActive(true);
            if(wasPlay == false)
            {
                dead.Play();
                wasPlay = true;
            }
            Time.timeScale = 0.0001f;
            isRepeat = true;
        }
        yield return new WaitForSeconds(0.0003f);
        Reload();
    }

    public void Reload()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
*/
    void Flip()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
        if(XMoveDirection > 0)
        {
            XMoveDirection = -1;
        }
        else
        {
            XMoveDirection = 1;
        }
    }
    }
