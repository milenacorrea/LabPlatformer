using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TemporaryMove : MonoBehaviour
{
    Rigidbody2D rb;
    float horz;
    public float speed = 10;
    private float itemsCollected;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        itemsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
      //  horz = Input.GetAxis("Horizontal");
      //  transform.Translate(Vector2.right * horz * speed * Time.deltaTime);

        MovePos();

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up * 6, ForceMode2D.Impulse);
        }

    }


    void MovePos()
    {
        Vector2 newPos = rb.position;
        newPos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        newPos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        rb.position = newPos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Item")
        {
            Destroy(collision.gameObject);
            itemsCollected++;
        }

        if (collision.gameObject.tag == "Next" && itemsCollected >= 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (collision.gameObject.tag == "Next2" && itemsCollected >= 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (collision.gameObject.tag == "Next3" && itemsCollected >= 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (collision.gameObject.tag == "Next4" && itemsCollected >= 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

}