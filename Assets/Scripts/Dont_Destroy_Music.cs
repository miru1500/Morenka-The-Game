using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dont_Destroy_Music : MonoBehaviour
{
    void Awake()
    {
        GameObject  objects = GameObject.FindGameObjectWithTag("music");

        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().name.Equals("MainMenu"))
            Destroy(this.gameObject);
    }
}
