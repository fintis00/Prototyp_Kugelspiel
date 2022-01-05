using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startmenu : MonoBehaviour
{
    public void spiel_laden()
    {
        SceneManager.LoadScene("Menu");
    }
}
