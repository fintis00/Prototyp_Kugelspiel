using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class test : MonoBehaviour
{
    public Text coinsText;
    public int gesamt;
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Coins"))
        {
            Debug.Log(PlayerPrefs.GetString("Scene", ""));
            if (PlayerPrefs.GetString("Scene", "").Equals("Level Y"))
            {
                Debug.Log(PlayerPrefs.GetString("Scene", ""));
                if (FindObjectOfType<array>().scores[1] < PlayerPrefs.GetInt("Coins", 0))
                {
                    FindObjectOfType<array>().scores[1] = PlayerPrefs.GetInt("Coins", 0);
                }
            }
            else if(PlayerPrefs.GetString("Scene", "").Equals("Level X"))
            {
                if (FindObjectOfType<array>().scores[0] < PlayerPrefs.GetInt("Coins", 0))
                {
                    FindObjectOfType<array>().scores[0] = PlayerPrefs.GetInt("Coins", 0);
                }
            }



            int i = PlayerPrefs.GetInt("Coins", 0);
            Debug.Log(i);
            


            
            
        }
        foreach (int x in FindObjectOfType<array>().scores)
        {
            gesamt += x;
        }
        Debug.Log("Gesamt: " + gesamt);
        coinsText.text = gesamt.ToString();

        Debug.LogWarning("start");
    }
}
