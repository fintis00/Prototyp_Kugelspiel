using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavasound : MonoBehaviour
{
    GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CustomTags>().HasTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("LavaDeath");
           
        }
    }
}
