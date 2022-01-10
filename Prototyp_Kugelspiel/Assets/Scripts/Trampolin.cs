using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour
{
    GameObject trampolin;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CustomTags>().HasTag("Player"))
        {
            other.GetComponent<Jumping>().jumpVelocity = 30;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<CustomTags>().HasTag("Player"))
        {
            other.GetComponent<Jumping>().jumpVelocity = 10;
            FindObjectOfType<AudioManager>().Play("trampolin");
        }
    }
    
}
