using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relativeMovement : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CustomTags>().HasTag("Player"))
        {
            collision.transform.SetParent(transform);
            
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.GetComponent<CustomTags>().HasTag("Player"))
        {
            collision.transform.SetParent(null);
            
        }
    }
}
