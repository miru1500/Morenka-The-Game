using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives_Decrement : MonoBehaviour
{
    public GameObject livesObject;
    private LiveMaster lm;
    public bool hasDied;
    public bool hasJumperDied;
    private bool isRepeat = false;
    public GameObject YouDied;
    public AudioSource dead;
    public AudioSource jumperDead;
    private bool wasPlay = false;
    public GameObject jumperSound;
    private int i = 1;
    public GameObject livesText;
    public GameObject blackGround;
    public int levelIndex;
    public GameObject levelMusic;
    public GameObject wysoko;
    public GameObject score;


    void Start()
    {
        lm = GameObject.FindGameObjectWithTag("LM").GetComponent<LiveMaster>();
        //Lives lives = livesObject.GetComponent<Lives>();
        StartCoroutine("ShowLives");
        hasDied = false;
        YouDied.gameObject.SetActive(false);
        Lives livesPlayer = livesObject.GetComponent<Lives>();
        Debug.Log("Lives: " + Lives.livesPlayer);
        i = 1;
    }

    void Update()
    {
        if(gameObject.transform.position.y < -7)
        {
            PlayMusic musicPlay = levelMusic.GetComponent<PlayMusic>();
            musicPlay.music.Stop();
            hasDied = true;
        }
        if(hasDied == true)
        {
            if(i == 1)
            {
                Lives livesPlayer = livesObject.GetComponent<Lives>();
                Lives.livesPlayer = Lives.livesPlayer - i;
                i = 0;
            }
            StartCoroutine("Die");
        }
        if(hasJumperDied == true)
        {
            if(i == 1)
            {
                Lives livesPlayer = livesObject.GetComponent<Lives>();
                Lives.livesPlayer = Lives.livesPlayer - i;
                i = 0;
            }
            StartCoroutine("JumperDie");
        }
        Audio_Trigger czyWysoko = wysoko.GetComponent<Audio_Trigger>();
        if(czyWysoko.czyJestWysoko == true)
        {
            PlayMusic musicPlay = levelMusic.GetComponent<PlayMusic>();
            musicPlay.music.Stop();
        }
        
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag.Equals("enemyDownKill") || col.gameObject.tag.Equals("kill"))
        {
            PlayMusic musicPlay = levelMusic.GetComponent<PlayMusic>();
            musicPlay.music.Stop();
            hasDied = true;
        }
        if(col.gameObject.tag.Equals("jumperDead"))
        {   
            PlayMusic musicPlay = levelMusic.GetComponent<PlayMusic>();
            Audio_Trigger audioTrigger = jumperSound.GetComponent<Audio_Trigger>();
            musicPlay.music.Stop();
            audioTrigger.soundJumper.Stop();
            hasJumperDied = true;
        }
    }

    IEnumerator ShowLives()
    {
        Time.timeScale = 0.0001f;
        if(levelIndex != 4)
        {
            livesText.SetActive(true);
            blackGround.SetActive(true);
            score.SetActive(false);
            yield return new WaitForSeconds(0.0001f);
            PlayMusic musicPlay = levelMusic.GetComponent<PlayMusic>();
            musicPlay.music.Play();
            livesText.SetActive(false);
            blackGround.SetActive(false);
            score.SetActive(true);
        }
        else if(levelIndex == 4)
        {
            PlayMusic musicPlay = levelMusic.GetComponent<PlayMusic>();
            musicPlay.music.Play();
            livesText.SetActive(false);
            blackGround.SetActive(false);
            yield return new WaitForSeconds(0f);
        }
        Time.timeScale = 1f;
    }

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
            Time.timeScale = 0.0002f;
            isRepeat = true;
        }
        yield return new WaitForSeconds(0.0005f);
        Reload();
    }

    IEnumerator JumperDie()
    {
        if(isRepeat == false)
        {
            Debug.Log("Player upad");
            YouDied.gameObject.SetActive(true);
            if(wasPlay == false)
            {
                jumperDead.Play();
                wasPlay = true;
            }
            Time.timeScale = 0.0001f;
            isRepeat = true;
        }
        yield return new WaitForSeconds(0.0005f);
        Reload();
    }

    public void Reload()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
