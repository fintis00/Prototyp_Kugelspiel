using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class test : MonoBehaviour
{
    [SerializeField]
    private GameObject punkte_L1;
    [SerializeField]
    private GameObject punkte_L2;
    [SerializeField]
    private GameObject punkte_L3;
    [SerializeField]
    private GameObject schloss1;
    public Text gesamt_coins;
    public int gesamt;
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Coins") && PlayerPrefs.HasKey("Scene"))
        {
            if (PlayerPrefs.GetInt("Scene") > 0)
            {
                int level = PlayerPrefs.GetInt("Scene", 0);



                
                if (FindObjectOfType<array>().scores[level] < PlayerPrefs.GetInt("Coins", 0))
                {
                    FindObjectOfType<array>().scores[level] = PlayerPrefs.GetInt("Coins", 0);
                }
            }
            
        }
        int[] scores = FindObjectOfType<array>().scores;
        punkte_L1.GetComponent<TextMesh>().text = scores[1].ToString() + "/20";
        punkte_L2.GetComponent<TextMesh>().text = scores[2].ToString() + "/20";
        punkte_L3.GetComponent<TextMesh>().text = scores[3].ToString() + "/10";
        foreach (int x in FindObjectOfType<array>().scores)
        {
            gesamt += x;
        }
        gesamt -= FindObjectOfType<array>().scores[0];
        schloss1.GetComponent<TextMesh>().text = gesamt.ToString() + "/40";
        
        gesamt_coins.text = gesamt.ToString();
    }
}
