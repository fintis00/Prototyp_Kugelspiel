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

    public void zur�ck()
    {
        SettingsUI.SetActive(false);
        PauseMenuUI.SetActive(true);
    }
}
