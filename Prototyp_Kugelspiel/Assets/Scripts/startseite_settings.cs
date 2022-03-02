using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startseite_settings : MonoBehaviour
{
    public GameObject SettingsUI;
    public GameObject StartUI;

    public void setFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void zurueck()
    {
        SettingsUI.SetActive(false);
        StartUI.SetActive(true);
    }
}
