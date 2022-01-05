using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class test : MonoBehaviour
{
    public Text gesamt_coins;
    public int gesamt;
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Coins"))
        {
            
            if (PlayerPrefs.GetInt("Scene", 0) == 2)
            {
               
                if (FindObjectOfType<array>().scores[1] < PlayerPrefs.GetInt("Coins", 0))
                {
                    FindObjectOfType<array>().scores[1] = PlayerPrefs.GetInt("Coins", 0);
                }
            }
            else if(PlayerPrefs.GetInt("Scene", 0) == 1)
            {
                if (FindObjectOfType<array>().scores[0] < PlayerPrefs.GetInt("Coins", 0))
                {
                    FindObjectOfType<array>().scores[0] = PlayerPrefs.GetInt("Coins", 0);
                }
            }
        }
        foreach (int x in FindObjectOfType<array>().scores)
        {
            gesamt += x;
        }
        Debug.Log("Gesamt: " + gesamt);
        gesamt_coins.text = gesamt.ToString();

        Debug.LogWarning("start");
    }
}
