using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public GameObject player;
    public GameObject respawn_point;

    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<AudioManager>().Play("death");
        collision.gameObject.transform.position = respawn_point.transform.position;
    }
}
