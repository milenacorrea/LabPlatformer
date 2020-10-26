using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 4;
    public float jumpForce = 500;
    public int MaxJumps = 1;
    
    int JumpCount = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        JumpCount = MaxJumps;
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(xSpeed, rb.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            if (JumpCount > 0)
            {
                rb.AddForce(new Vector2(0, jumpForce));
                JumpCount -= 1;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            JumpCount = MaxJumps;
        }
    }
}
