using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startmenu : MonoBehaviour
{
    public void spiel_laden()
    {
        PlayerPrefs.SetInt("Scene", 0);
        SceneManager.LoadScene("Menu");
    }

    public void startCredits()
    {
        FindObjectOfType<AudioManager>().Stop("Hauptmenu");
        FindObjectOfType<AudioManager>().Play("Credits");
        SceneManager.LoadScene("Credits");
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void anleitung_auf()
    {
        SceneManager.LoadScene("Anleitung");
    }
}
