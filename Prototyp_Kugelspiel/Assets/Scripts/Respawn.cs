using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public GameObject player;
    public GameObject respawn_point;

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.position = respawn_point.transform.position;
        FindObjectOfType<AudioManager>().Play("death");
        if (PlayerPrefs.GetInt("Coins", 0) > 0)
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins", 0) -1);
    }
}
