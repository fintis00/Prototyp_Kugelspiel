using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{

    [SerializeField]
    public float jumpVelocity;

    [SerializeField]
    public Rigidbody rb;
    [SerializeField]
    public GameObject player;

    public bool grounded;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;

    }

    
    void Update()
    {
       
        if (Input.GetButtonDown("Jump")&& grounded)
        {
            FindObjectOfType<AudioManager>().Play("jump");
            grounded = false;
            rb.velocity = Vector3.up * (jumpVelocity + rb.velocity.y);

        }
        
    }
}