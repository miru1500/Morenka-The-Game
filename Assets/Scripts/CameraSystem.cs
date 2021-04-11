using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    private GameObject player;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    private float x;
    private float y;
    private float actualPosition;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
      //  Screen.SetResolution(800, 600, false);

        x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        actualPosition = x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
        if(x > actualPosition)
        {
            actualPosition = x;
        }
        gameObject.transform.position = new Vector3 (actualPosition,y,gameObject.transform.position.z);
    }
}
