using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class SettingsController : MonoBehaviour
{

    public static bool settingsAreOpen = false;
    public GameObject SettingsUI;
    public GameObject PauseMenuUI;
    public GameObject slider;
    private float volume;

    

    // Update is called once per frame
    void changeVolume(float vol)
    {
        
        volume = vol;

    }

    public void zurueck()
    {
        Sound[] temp = FindObjectOfType<AudioManager>().sounds;
        foreach(Sound sound in temp)
        {
            sound.volume=volume;
        }
        SettingsUI.SetActive(false);
        PauseMenuUI.SetActive(true);
    }
}
