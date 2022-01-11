using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class credits : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(gameObject,2000,15).setEaseInOutSine();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y == 2000)
        {
            FindObjectOfType<AudioManager>().Stop("Credits");
            PlayerPrefs.SetInt("Scene", 0);
            FindObjectOfType<AudioManager>().Play("Hauptmenu");
            SceneManager.LoadScene("Startmenu");      
        }
    }
}
