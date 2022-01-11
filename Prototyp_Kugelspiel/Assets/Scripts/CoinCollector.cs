using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    [SerializeField]
    public int amount = 1;
    //public static List namesOfDestroyedObjects = new List();


    void Start()
    {
        //PlayerPrefs.SetInt("Coins", 0);
        //if (namesOfDestroyedObjects.Count > 0)
        //{

        //    for (int i = 0; i < namesOfDestroyedObjects.Count; i++)
        //    {

        //        Destroy(GameObject.Find(namesOfDestroyedObjects[i]));
        //    }

        //}


    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<CustomTags>().HasTag("Player"))
        {
            if (tag == "stern")
                FindObjectOfType<AudioManager>().Play("stern");
            else
                FindObjectOfType<AudioManager>().Play("CoinCollect");
            PlayerPrefs.SetInt("Coins",PlayerPrefs.GetInt("Coins",0)+amount);
            //    collision.gameObject.GetComponent<Points>().points += amount;
            
            Destroy(gameObject);

            
            //namesOfDestroyedObjects.Add(this.gameObject.name);
            

        }
    }
}
