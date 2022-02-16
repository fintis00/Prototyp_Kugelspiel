using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snow_grow : MonoBehaviour
{
    [SerializeField] private GameObject player; //Spieler
    [SerializeField] private Vector3 scaleChange;
    [SerializeField] private Vector3 maxSize;
    [SerializeField] private float jump_velocity;
    bool entered = false;


    void OnTriggerEnter(Collider other)
    {
        entered = true;
    }

    void Update()
    {
        //Debug.Log(player.GetComponent<Rigidbody>().velocity.magnitude);

        if (entered)
        {
            GameObject.Find("Player").GetComponent<Jumping>().jumpVelocity = jump_velocity;
            if (player.GetComponent<Rigidbody>().velocity.magnitude > 2) //triggered nur wenn geschwindigkeit > 4
                if (player.transform.localScale.x < maxSize.x) //solang der spieler kleiner ist als maxSize
                    player.transform.localScale += scaleChange * player.transform.localScale.x; //erhöht die größe des spielers um die werte von ScaleChange * die größe des spielers

        }
    }

    void OnTriggerExit(Collider other)
    {
        entered = false;
    }
}
