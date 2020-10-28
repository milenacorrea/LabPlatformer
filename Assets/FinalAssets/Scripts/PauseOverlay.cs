using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseOverlay : MonoBehaviour
{
    public GameObject pauseOverlay;

    void Update()
    {
       

if(!PublicVars.isPaused && Input.GetKeyDown(KeyCode.Escape)){
Time.timeScale = 0;
PublicVars.isPaused = true;
pauseOverlay.SetActive(true);
}
else if(PublicVars.isPaused && Input.GetKeyDown(KeyCode.Space)){
Time.timeScale = 1;
PublicVars.isPaused = false;
pauseOverlay.SetActive(false);
}else if(PublicVars.isPaused && Input.GetKeyDown(KeyCode.Escape)){
Application.Quit();
}
    }
}
