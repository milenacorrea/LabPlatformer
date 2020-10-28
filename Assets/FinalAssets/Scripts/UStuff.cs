using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UStuff : MonoBehaviour
{
    public Text crawl;
    public Text items;
    void Start()
    {
        items.enabled = false;
        crawl.enabled = false;
    }
}