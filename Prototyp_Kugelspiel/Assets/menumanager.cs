using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class menumanager : MonoBehaviour
{

    public Text coins_Text;
    int chk = 0;
    public GameObject Gate456;
    public GameObject Gate789;

    public int level456 = 100;
    public int level789 = 100;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetInt("Coins", 0);

    }

    void Update()
    {
        coins_Text.text = (PlayerPrefs.GetInt("Coins", 0)).ToString();

        if (chk == 0)
        {
            if (PlayerPrefs.GetInt("Coins", 0) >= level456)
            {
                GameObject.Destroy(Gate456);
                print("Destoryed the gate");
                chk = 1;
            }
            if (PlayerPrefs.GetInt("Coins", 0) >= level789)
            {
                GameObject.Destroy(Gate789);
                print("Destoryed the gate");
                chk = 1;
            }
        }
    }


}
