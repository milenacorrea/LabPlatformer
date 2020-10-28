using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemD2 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("hit!");
            Global.count2--;
            Destroy(this.gameObject);
        }
    }
}
