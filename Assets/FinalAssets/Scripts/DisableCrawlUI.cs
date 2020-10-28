using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableCrawlUI : MonoBehaviour
{
 public Text Crawl;
 public Text Items;

 void start()
 {
     Items.enabled = false;
 }

   void OnCollisionEnter2D(Collision2D collision)
   {
       if (collision.gameObject.tag == "Player")
       {
           Crawl.enabled = false;
           Items.enabled = true;
           Destroy(this.gameObject);
       }

   }
}
