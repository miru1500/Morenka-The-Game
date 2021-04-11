using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Move_Vertical : MonoBehaviour
{
private float moveSpeed = 3f;
    private bool moveUp = true;

    [SerializeField]
    private float edgeUp = 4f;
    [SerializeField]
    private float edgeDown = -4f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > edgeUp)
        {
            moveUp = true;
        }
        if(transform.position.y < edgeDown)
        {
            moveUp = false;
        }
        if(moveUp == true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
            //transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
            //transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        }
    }
}
