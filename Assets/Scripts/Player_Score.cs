using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{
    public int playerScore;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;
    private bool isRepeat = false;
    public GameObject YouDied;
    public AudioSource dead;
    private bool wasPlay = false;
    public int levelIndex;
    public AudioSource win;
    public GameObject levelMusic;

    // Update is called once per frame
    void Start()
    {
      //  Time.timeScale = 1;
        YouDied.gameObject.SetActive(false);
    }

    void FixedUpdate()
    {
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "coin")
        {
            playerScore += 10;
            col.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {   
        if(col.gameObject.name == "EndLevel")
        {    
            CountScore();
        }
        if(col.gameObject.tag == "coin")
        {    
            playerScore += 10;
            col.gameObject.SetActive(false);
        }
        if(col.gameObject.tag == "coinDestroy")
        {    
            col.gameObject.SetActive(false);
        }
        if(col.gameObject.tag == "megaCoin")
        {    
            playerScore = 2137;
            col.gameObject.SetActive(false);
        }
        if(col.gameObject.name == "EndLevel")
        {
            PlayMusic musicPlay = levelMusic.GetComponent<PlayMusic>();
            musicPlay.music.Stop();
            StartCoroutine("Win");
        }
        if(col.gameObject.name == "EndGame")
        {
            StartCoroutine("End");
        }
    }

    void CountScore()
    {
        Debug.Log(playerScore);
    }

    public void Reload()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

/*    IEnumerator Die()
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
    }*/

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(levelIndex);
    }

    IEnumerator Win()
    {
        if(isRepeat == false)
        {
            if(wasPlay == false)
            {
                win.Play();
                wasPlay = true;
            }
            Time.timeScale = 0.0001f;
            isRepeat = true;
        }
        yield return new WaitForSeconds(0.0002f);
        LoadNextLevel();
    }

    IEnumerator End()
    {
        if(isRepeat == false)
        {
            if(wasPlay == false)
            {
                win.Play();
                wasPlay = true;
            }
            Time.timeScale = 0.0001f;
            isRepeat = true;
        }
        yield return new WaitForSeconds(0.00035f);
        LoadNextLevel();
    }
}
