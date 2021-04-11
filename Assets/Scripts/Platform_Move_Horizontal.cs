using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Platform_Move_Horizontal : MonoBehaviour
{
    private float moveSpeed = 3f;
    private bool moveRight = true;

    [SerializeField]
    private float edgeRight = 4f;
    [SerializeField]
    private float edgeLeft = -4f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > edgeRight)
        {
            moveRight = true;
        }
        if(transform.position.x < edgeLeft)
        {
            moveRight = false;
        }
        if(moveRight == true)
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        }
    }

}
