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
        SceneManager.LoadScene("Credits");
    }
}
