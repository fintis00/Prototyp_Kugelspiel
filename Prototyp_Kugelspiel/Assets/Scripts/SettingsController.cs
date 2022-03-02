using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Audio;


public class SettingsController : MonoBehaviour
{
    [SerializeField]
    private GameObject SettingsUI;
    [SerializeField]
    private GameObject PauseMenuUI;
    public GameObject points;
    
    public AudioMixer mainMixer;

   public void setFullscreen(bool isFullscreen)
   {
       Screen.fullScreen = isFullscreen;
   }

    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void setVolume(float volume)
    {
        mainMixer.SetFloat("volume", volume);
    }

    public void zurueck()
    {
        SettingsUI.SetActive(false);
        PauseMenuUI.SetActive(true);
        points.SetActive(true);

    }
}
