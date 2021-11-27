using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{

    [SerializeField]
    public float jumpVelocity;

    [SerializeField]
    public Rigidbody rb;

    private bool jumpable = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public bool getJumpable()
    {
        return jumpable;
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.GetComponent<CustomTags>().HasTag("Jumpable"))
        {
            jumpable = true;
        }
        if (other.gameObject.GetComponent<CustomTags>().HasTag("Trampolin"))
        {
            jumpVelocity = 30f;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.GetComponent<CustomTags>().HasTag("Jumpable"))
        {
            jumpable = false;
        }
        if (other.gameObject.GetComponent<CustomTags>().HasTag("Trampolin"))
        {
            jumpVelocity = 10f;
        }
    }


    void Update()
    {

        if (Input.GetButtonDown("Jump") && jumpable)
        {
            rb.velocity = Vector3.up * (jumpVelocity + rb.velocity.y);

        }
    }
}