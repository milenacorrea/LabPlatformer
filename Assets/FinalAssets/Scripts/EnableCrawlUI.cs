using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableCrawlUI : MonoBehaviour
{
    public Text Crawl;

    void start()
    {
        Crawl.enabled = false;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Crawl.enabled = true;
            Destroy(this.gameObject);
        }
    }
}
