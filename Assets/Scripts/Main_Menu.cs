using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public string LvToLoad;

    public int dfltLives;

    private void Start() 
        {
            PlayerPrefs.SetInt("CurrentLives",dfltLives);
        }

    public void PlayGame()
    {
        SceneManager.LoadScene(LvToLoad);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
