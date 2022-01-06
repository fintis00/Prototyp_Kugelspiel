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
            int level = PlayerPrefs.GetInt("Scene", 0)-1;


            if (FindObjectOfType<array>().scores[level] < PlayerPrefs.GetInt("Coins", 0))
            {
                FindObjectOfType<array>().scores[level] = PlayerPrefs.GetInt("Coins", 0);
            }
            
        }
        foreach (int x in FindObjectOfType<array>().scores)
        {
            gesamt += x;
        }
        
        gesamt_coins.text = gesamt.ToString();
    }
}
