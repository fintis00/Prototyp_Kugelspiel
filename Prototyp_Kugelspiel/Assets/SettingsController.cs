using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsController : MonoBehaviour
{

    public static bool settingsAreOpen = false;
    public GameObject SettingsUI;
    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void zurück()
    {
        SettingsUI.SetActive(false);
        PauseMenuUI.SetActive(true);
    }
}
