using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 4;
    public float jumpForce = 500;
    public int MaxJumps = 1;

    public int MaxJumpsCrawl = 0;
    int JumpCount = 0;

    public bool disableJump;
    public bool isGrounded;

    BoxCollider2D coll;

    Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        coll = GetComponent<BoxCollider2D>();
        JumpCount = MaxJumps;
    }

    // Update is called once per frame
    void Update()
    {
        if (PublicVars.isPaused)
        {
            return;
        }

        Debug.Log(JumpCount);

        float xSpeed = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(xSpeed, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(xSpeed));

        ////////////////////////////////////////////////////

        if(Input.GetButtonDown("Jump"))
        {
            if (JumpCount > 0)
            {
                rb.AddForce(new Vector2(0, jumpForce));
                isGrounded = false;
                JumpCount -= 1;
            }
        }

        else
        {
            animator.SetBool("isDown", false);
        }

        if (xSpeed < 0 && transform.localScale.x > 0)
        {
            transform.localScale *= new Vector2(-1 ,1);
        }

        else if (xSpeed > 0 && transform.localScale.x < 0)
        {
            transform.localScale *= new Vector2(-1, 1);
        }

        if (isGrounded == true)
        {
            animator.SetBool("inAir", false);
        }
        
        else
        {
            animator.SetBool("inAir", true);
        }


        if(Input.GetKey(KeyCode.DownArrow) || Input.GetButton("Fire2"))
        {
            animator.SetBool("isDown", true);
            //coll.size = new Vector2(2.7f,4.4f);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            JumpCount = MaxJumps;
            isGrounded = true;
        }

        if (collision.gameObject.tag == "Dead")
        {
            Scene sceney = SceneManager.GetActiveScene();
            SceneManager.LoadScene(sceney.name);
        }

        if (collision.gameObject.tag == "Exit1")
        {
            if (Global.count1 == 0)
            {
                SceneManager.LoadScene("2Easy");
            }

        }

        if (collision.gameObject.tag == "Exit2")
        {
            if (Global.count2 == 0)
            {
                SceneManager.LoadScene("3Medium");
            }

        }

        if (collision.gameObject.tag == "Exit3")
        {
            if (Global.count3 == 0)
            {
                SceneManager.LoadScene("4Medium");
            }

        }

        if (collision.gameObject.tag == "Exit4")
        {
            if (Global.count4 == 0)
            {
                SceneManager.LoadScene("7Hard");
            }

        }

        if (collision.gameObject.tag == "Exit5")
        {
            if (Global.count5 == 0)
            {
                SceneManager.LoadScene("6Hard");
            }

        }

        if (collision.gameObject.tag == "Exit6")
        {
            if (Global.count6 == 0)
            {
                SceneManager.LoadScene("7Hard");
            }

        }

        if (collision.gameObject.tag == "Exit7")
        {
            if (Global.count7 == 0)
            {
                SceneManager.LoadScene("EndScreen");
            }
        }
    }
}
