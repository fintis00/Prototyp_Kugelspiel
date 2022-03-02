using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public GameObject current_checkpoint;
    public GameObject respawnpoint;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            current_checkpoint.transform.position = respawnpoint.transform.position;
            Destroy(gameObject);
        }
    }
}
