using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public GameObject optionsmenu;
    public GameObject mainmenu;

    public void play()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }

    public void quit()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}