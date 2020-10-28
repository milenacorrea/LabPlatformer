using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    // public Button Level1;
    // public Button Level2;
    // public Button Level3;
    // public Button Level4;
    // public Button Level5;
    // public Button Exit;
    // public Button LevelSelector;

    void Start()
    {
        // Button button = Level1.GetComponent<Button>();
        // button.onClick.AddListener(StartGame);
        
        // Button button2 = Level2.GetComponent<Button>();
        // button2.onClick.AddListener(LoadLevel2);   
        
        // Button button3 = Level3.GetComponent<Button>();
        // button3.onClick.AddListener(LoadLevel3);   
        
        // Button button4 = Level4.GetComponent<Button>();
        // button4.onClick.AddListener(LoadLevel4);   
        
        // Button button5 = Level5.GetComponent<Button>();
        // button5.onClick.AddListener(LoadLevel5);   
        
        // Button button6 = Exit.GetComponent<Button>();
        // button6.onClick.AddListener(ExitGame);   
        
        // Button button7 = LevelSelector.GetComponent<Button>();
        // button7.onClick.AddListener(LoadLevelSelect);   
        
            }
     public void StartGame()
    {
        SceneManager.LoadScene("1Easy");
    }

    public void LoadLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("2Easy");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("3Medium");
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene("4Medium");
    }

    public void LoadLevel5()
    {
        SceneManager.LoadScene("7Hard");
    }

    public void TitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }

}
