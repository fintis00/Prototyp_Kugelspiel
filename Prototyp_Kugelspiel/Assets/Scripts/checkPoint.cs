using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class checkPoint : MonoBehaviour
{
    public GameObject current_checkpoint;
    public GameObject respawnpoint;
    public ParticleSystem particleSystem;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            current_checkpoint.transform.position = respawnpoint.transform.position;
            Destroy(gameObject);
            var em = particleSystem.emission;
            em.enabled = true;
            FindObjectOfType<AudioManager>().Play("Checkpoint");
        }
    }
}
