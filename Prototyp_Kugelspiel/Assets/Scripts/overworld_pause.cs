using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class overworld_pause : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject settingsUI;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !gameIsPaused)
        {

            Pause();
            Cursor.visible = true;
        }
        
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        Cursor.visible = false; 
    }

    public void LoadMenu()
    {
        settingsUI.SetActive(true);
        PauseMenuUI.SetActive(false);
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void quitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Startmenu");
        PlayerPrefs.SetInt("Scene", -1);
        gameIsPaused=false;
        Cursor.visible = true;
    }
}
