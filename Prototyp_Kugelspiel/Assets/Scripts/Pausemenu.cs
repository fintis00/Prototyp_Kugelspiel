using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pausemenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject settingsUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&&!gameIsPaused)
        {
            
            Pause();
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void LoadMenu()
    {
        settingsUI.SetActive(true);
        PauseMenuUI.SetActive(false);
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
        FindObjectOfType<AudioManager>().Stop("Level1");
        if (PlayerPrefs.GetString("Scene", "") == "Level1") {
            FindObjectOfType<AudioManager>().Stop("Level1_background");
        }
        PlayerPrefs.SetInt("Coins", 0);
        SceneManager.LoadScene("Menu");
    }

}
