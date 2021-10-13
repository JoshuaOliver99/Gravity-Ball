using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{

    // ----- References -----
    // Ball...
    GameObject ball;
    GravitySwitcher ballGravitySwitcher;

    // Menu...
    [SerializeField, Tooltip("The in-game menu")] GameObject Menu;


    void Start()
    {
        // if (not the main menu)
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name != "MainMenu")
        {
            // Setup...
            ball = GameObject.FindGameObjectWithTag("Player");
            ballGravitySwitcher = ball.GetComponent<GravitySwitcher>();
        }

    }





    // NOTE: 1ST Drafts
    public void setGravity_Up()
    {
        ballGravitySwitcher.SetGravity_Up();
    }
    public void setGravity_Down()
    {
        ballGravitySwitcher.SetGravity_Down();
    }
    public void setGravity_Left()
    {
        ballGravitySwitcher.SetGravity_Left();
    }
    public void setGravity_Right()
    {
        ballGravitySwitcher.SetGravity_Right();
    }


    public void Btn_ToggleMenu()
    {
        Menu.SetActive(!Menu.activeSelf);
    }


    public void Btn_MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void Btn_LoadLevel(string level)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(level);
    }

    public void Btn_RestartLevel()
    {
        // To Do
        // First save any stats...

        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    public void Btn_Quit()
    {
        Application.Quit();
    }
}
