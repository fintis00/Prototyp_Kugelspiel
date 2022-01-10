<<<<<<< Updated upstream
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CustomTags>().HasTag("Player"))
        {
            collision.gameObject.GetComponent<Points>().points++;
            Destroy(gameObject);
        }
    }
}
=======
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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CustomTags>().HasTag("Player"))
        {
            if (tag == "star")
                FindObjectOfType<AudioManager>().Play("star");
            else
                FindObjectOfType<AudioManager>().Play("CoinCollect");
            PlayerPrefs.SetInt("Coins",PlayerPrefs.GetInt("Coins",0)+amount);
            //    collision.gameObject.GetComponent<Points>().points += amount;
            print("=====Coins store logic====");
            Destroy(gameObject);

            
            //namesOfDestroyedObjects.Add(this.gameObject.name);
            

        }
    }
}
>>>>>>> Stashed changes
