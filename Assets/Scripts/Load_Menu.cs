using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoadMenu");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("MainMenu");
    }
}
