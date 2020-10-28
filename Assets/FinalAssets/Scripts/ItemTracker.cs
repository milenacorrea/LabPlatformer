using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Global
{
    public static int count1;
    public static int count2;
    public static int count3;
    public static int count4;
    public static int count5;
    public static int count6;
    public static int count7;
}

public class ItemTracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objects1;
        objects1 = GameObject.FindGameObjectsWithTag("objects1");
        Global.count1 = objects1.Length;

        GameObject[] objects2;
        objects2 = GameObject.FindGameObjectsWithTag("objects2");
        Global.count2 = objects2.Length;

        GameObject[] objects3;
        objects3 = GameObject.FindGameObjectsWithTag("objects3");
        Global.count3 = objects3.Length;

        GameObject[] objects4;
        objects4 = GameObject.FindGameObjectsWithTag("objects4");
        Global.count4 = objects4.Length;

        GameObject[] objects5;
        objects5 = GameObject.FindGameObjectsWithTag("objects5");
        Global.count5 = objects5.Length;

        GameObject[] objects6;
        objects6 = GameObject.FindGameObjectsWithTag("objects6");
        Global.count6 = objects6.Length;
        
        GameObject[] objects7;
        objects7 = GameObject.FindGameObjectsWithTag("objects7");
        Global.count7 = objects7.Length;
    }
}
