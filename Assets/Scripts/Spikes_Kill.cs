using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes_Kill : MonoBehaviour
{
    public bool hasDied;
    private bool isRepeat = false;
    public GameObject YouDied;
    public AudioSource dead;
    private bool wasPlay = false;

    // Start is called before the first frame update
    void Start()
    {
     //   Time.timeScale = 1;
        hasDied = false;
        YouDied.gameObject.SetActive(false);
    }

    void Update()
    {
        if(hasDied == true)
        {
            StartCoroutine("Die");
        }
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            hasDied = true;
        }
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
}
