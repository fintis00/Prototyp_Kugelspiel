using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField]
    int amount = 1;
    //public static List namesOfDestroyedObjects = new List();


    void Start()
    {
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
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + amount);
        //    collision.gameObject.GetComponent<Points>().points += amount;
            print("=====Coins store logic====");
            Destroy(gameObject);
            //namesOfDestroyedObjects.Add(this.gameObject.name);

        }
    }
}
