using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    private static GameMaster instance;
    public Vector2 lastCheckPointPos;

    // Start is called before the first frame update
    void Start()
    {
       // lastCheckPointPos.x = 70f;
        //lastCheckPointPos.y = -3.18f;
        if(instance == null)
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
             Destroy(gameObject);
       }
    }
}
