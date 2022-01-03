using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField]
    int amount = 1;

    void Start()
    {
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<CustomTags>().HasTag("Player"))
        {
            collision.gameObject.GetComponent<Points>().points += amount;
            Destroy(gameObject);
        }
    }
}
