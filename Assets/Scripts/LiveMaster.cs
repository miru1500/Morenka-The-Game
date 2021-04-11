using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LiveMaster : MonoBehaviour
{
    private static LiveMaster instance;
    public GameObject livesObject;

    // Start is called before the first frame update
    void Start()
    {
        Lives livesPlayer = livesObject.GetComponent<Lives>();
        // lastCheckPointPos.x = 70f;
        //lastCheckPointPos.y = -3.18f;
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
       /* else
        {
            Destroy(gameObject);
        }*/
    }

    void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
       if (scene.name == "Level4")
       {
            Lives livesPlayer = livesObject.GetComponent<Lives>();
            Lives.livesPlayer = 2;
            Debug.Log("Lives: " + Lives.livesPlayer);
            Debug.Log("Object destroyed");
            Destroy(gameObject);
       }
    }
}
