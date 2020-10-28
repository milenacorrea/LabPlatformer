using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemD7 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("hit!");
            Global.count7--;
            Destroy(this.gameObject);
        }
    }
}
