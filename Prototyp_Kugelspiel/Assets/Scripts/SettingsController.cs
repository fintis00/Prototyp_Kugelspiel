using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Audio;


public class SettingsController : MonoBehaviour
{
    [SerializeField]
    private GameObject points;
    [SerializeField]
    private GameObject SettingsUI;
    [SerializeField]
    private GameObject PauseMenuUI;
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private Text volume_text;
    private float volume;
    private float orig_volume;
    private Sound s;
    public AudioMixer audiomixer;

    private void Start()
    {
        volume_text.text = ((int)(volume * 100)).ToString() + "%";
    }

    public void changeVolume(float volume)
    {
        audiomixer.SetFloat("MyExposedParam", volume);
    }

    public void zurueck()
    {
        SettingsUI.SetActive(false);
        PauseMenuUI.SetActive(true);
    }
}
