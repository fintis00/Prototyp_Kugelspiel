using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pausemenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject settingsUI;
    public GameObject points;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&&!gameIsPaused)
        {
            
            Pause();
            Cursor.visible=true;
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
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
        points.SetActive(false);
    }

    public void confirm()
    {
        FindObjectOfType<DialogueTrigger>().TriggerDialogue();
    }
    public void QuitGame()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
        FindObjectOfType<AudioManager>().Stop("Level1");
            FindObjectOfType<AudioManager>().Stop("Level"+ PlayerPrefs.GetInt("Scene", 0)+ "_background");
        PlayerPrefs.SetInt("Coins", 0);
        FindObjectOfType<AudioManager>().Play("Hauptmenu");
        SceneManager.LoadScene("Menu");
    }

    public void yes()
    {
        QuitGame();
    }
    

}
