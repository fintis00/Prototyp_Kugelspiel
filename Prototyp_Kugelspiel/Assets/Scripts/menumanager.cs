using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class menumanager : MonoBehaviour
{
    public Dialogue dialogue;
    public Text coins_Text;
    int chk = 0;
    public GameObject gate1_points;
    public GameObject Gate456;
    public GameObject Gate789;
    public GameObject wall;
    public GameObject cam;

    public int level456 = 100;
    public int level789 = 100;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.GetInt("Coins", 0);

    }

    void Update()
    {
        

        if (chk == 0)
        {
            if (cam.GetComponent<test>().gesamt >= level456)
            {
                Destroy(wall);
                Destroy(gate1_points);
                GameObject.Destroy(Gate456);
                chk = 1;

                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

            }
            if (cam.GetComponent<test>().gesamt >= level789)
            {
                GameObject.Destroy(Gate789);
                chk = 1;
            }
        }
    }


}
