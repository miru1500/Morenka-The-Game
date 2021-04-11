using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public Texture Background;
    public float WidthOfButton = 200;
    public float HeightOfButton = 70;
    private float Stride = 20;

    void Start()
    {
        Screen.SetResolution(800, 600, false);
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0,0,800,600), Background);
        if (GUI.Button(new Rect(300, 180, WidthOfButton, HeightOfButton), "Start Game"))
        {
            SceneManager.LoadScene("Level1");
        }
        if (GUI.Button(new Rect(300, 180 + (HeightOfButton + Stride), WidthOfButton, HeightOfButton), "Credits"))
        {
            SceneManager.LoadScene("Credits");
        }
        if (GUI.Button(new Rect(300, 180 + (HeightOfButton + Stride) * 2, WidthOfButton, HeightOfButton), "Exit Game"))
        {
            Application.Quit();
        }
    }
}
