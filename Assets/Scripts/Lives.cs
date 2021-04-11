using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    private static Lives instance;
    private GameMaster gm;
    public GameObject livesUI;
    static public int livesPlayer = 2;
    public int i = 1;
    public int levelIndex;

    void Start()
    {
        // lastCheckPointPos.x = 70f;
        //lastCheckPointPos.y = -3.18f;
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        if (levelIndex == 4)
        {
            Debug.Log("SCENA 4");
            livesPlayer = 2;
            Debug.Log("Żyćka: " + livesPlayer);
        }
        /* else
         {
             Destroy(gameObject);
         }*/
    }

    void Awake()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        livesUI.gameObject.GetComponent<Text>().text = ("X  " + livesPlayer);
      //  StartCoroutine("Die");
    }

/*    void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        if (scene.name == "Level4")
        {
            Debug.Log("SCENA 4");
            livesPlayer = 2;
        }
    }*/
    /*
        IEnumerator Die()
        {
            Time.timeScale = 0.0001f;
            yield return new WaitForSeconds(0.0001f);
            Time.timeScale = 1f;
        }*/
}
