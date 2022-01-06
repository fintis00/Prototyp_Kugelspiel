using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class SettingsController : MonoBehaviour
{
    public bool s_are_open=false;
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


    private void Start()
    {
        s_are_open = true;
        Sound[] temp = FindObjectOfType<AudioManager>().sounds;
        s = Array.Find(temp, sound => (sound.name).Equals("BackgroundAmbience"));
        slider.value = s.volume;
        orig_volume = s.volume;
    }
    // Update is called once per frame
    public void changeVolume(float vol)
    {
        volume = vol;
        volume_text.text = ((int)(volume*100)).ToString() + "%";
        

    }

    public void zurueck()
    {
        Sound[] temp = FindObjectOfType<AudioManager>().sounds;
        s = Array.Find(temp, sound => (sound.name).Equals("BackgroundAmbience"));
        s_are_open = false;
        s.volume = volume;
        SettingsUI.SetActive(false);
        PauseMenuUI.SetActive(true);
    }
}
