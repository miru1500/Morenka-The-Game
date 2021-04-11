using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trollface_Move_Up : MonoBehaviour
{
    //private GameObject script;
    private bool isEnter = false;
    private bool wasPlay = false;

    [SerializeField]
    public GameObject g_object;
    [SerializeField]
    private float trapSpeed = 5f;
/*    [SerializeField]
    private AudioSource audioSource;*/

    // Start is called before the first frame update
    void Start()
    {
        Trap_Move_Left X = g_object.GetComponent<Trap_Move_Left>();
        Trap_Move_Left Y = g_object.GetComponent<Trap_Move_Left>();
        // rb = g_object.GetComponent<Rigidbody2D>();
        // rb.constraints = RigidbodyConstraints2D.FreezePositionX;
    }

    void Update()
    {
        if (isEnter == true)
        {
            //  RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(0, 1));
         //   Trap_Move_Left.vector = new Vector2(0, 1) * trapSpeed;
            Debug.Log("Trollface trigger");
            //  rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Trollface trigger");
         //  rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            isEnter = true;
            Trap_Move_Left X = g_object.GetComponent<Trap_Move_Left>();
            Trap_Move_Left Y = g_object.GetComponent<Trap_Move_Left>();
            //  Trap_Move_Left.values.isEnter = false;
            /*            if (wasPlay == false)
                        {
                            audioSource.Play();
                            wasPlay = true;
                        }*/
        }
    }
}
