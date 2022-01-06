using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuM : MonoBehaviour
{
    public Text coinsText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Coins", 0);
    }
	
	void Update()
    {
        if (SceneManager.GetActiveScene().name != "Menu")
        {
            coinsText.text = PlayerPrefs.GetInt("Coins", 0).ToString();
        }
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
