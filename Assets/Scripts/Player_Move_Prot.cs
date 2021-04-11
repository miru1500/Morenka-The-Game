using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Move_Prot : MonoBehaviour
{
    private bool facingRight = false;
    private float jumpTimeCounter;
    private bool stoppedJumping;
    private float moveX = 0f;
    private bool isJump = false;
    private Rigidbody2D rb;

    [SerializeField]
    private float playerSpeed = 10f;
    [SerializeField]
    private int jumpPower = 1250;
    [SerializeField]
    private float jumpTime;
    [SerializeField]
    private bool isGrounded;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private AudioSource jumpSound;
   
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpTimeCounter = jumpTime;
    }

    void FixedUpdate()
    {
        PlayerMove();
     //   moveX = Input.GetAxis("Horizontal") * playerSpeed;
        animator.SetFloat("Speed", Mathf.Abs(moveX));
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Main");
        }
    }

    void PlayerMove()
    {
        if(isGrounded)
        {
            jumpTimeCounter = jumpTime;
        }

        //Controls
        moveX = Input.GetAxis("Horizontal") * playerSpeed;

        //wciśnięcie przycisku skoku
        if (Input.GetButton("Jump") && isGrounded == true && isJump == false)
        {
            //Jump();

            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            jumpSound.Play();
            isJump = true;
            StartCoroutine("IsJump");
        }

        //przytrzymanie przycisku skoku
        if (Input.GetButton("Jump") && isJump && (jumpTimeCounter > 0))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            jumpTimeCounter -= Time.deltaTime;
        }

        //puszczenie przycisku stopu
        if (Input.GetButtonUp("Jump"))
        {
            jumpTimeCounter = 0;
            isJump = false;
        }


        //Player direction
        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        //Physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    IEnumerator IsJump()
    {
        yield return new WaitForSeconds(0.4f);
        isJump = false;
    }

    void Jump()
    {
        //rb.velocity = new Vector2(rb.velocity.x, jumpPower);
     //   GetComponent<Rigidbody2D>().AddForce (Vector2.up * jumpPower);
      //  animator.SetBool("IsJumping", true);
      //  isGrounded = false;
    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag.Equals("questionTrigger"))
        {
            col.gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.tag == "ground")
        {
            animator.SetBool("IsJumping", false);
            isGrounded = true;
        }

        if(col.gameObject.tag.Equals("ceiling"))
        {
            jumpTimeCounter = 0;
            isJump = false;
        }

        if(col.gameObject.name.Equals("GroundParent"))
        {
            this.transform.parent = col.transform;
        }
        if(col.gameObject.name.Equals("CoinBox"))
        {
            Destroy(col.gameObject);
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground")
        {
            animator.SetBool("IsJumping", false);
            isGrounded = true;
        }
    }

    void OnCollisionExit2D (Collision2D col)
    {
        if (col.gameObject.name.Equals("GroundParent"))
        {
            this.transform.parent = null;
        }
        if(col.gameObject.tag == "ground")
        {
            animator.SetBool("IsJumping", true);
            isGrounded = false;
        }
    }
}
