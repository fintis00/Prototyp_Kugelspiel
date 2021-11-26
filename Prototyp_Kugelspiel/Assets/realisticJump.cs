using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realisticJump : MonoBehaviour
{
    [SerializeField]
    public float fallMultiplier;
    [SerializeField]
    public float lowJumpMultiplier;

    Rigidbody rb;

    private bool grounded = false;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }
    void FixedUpdate()
    {

        if (!grounded)
        {
            if (rb.velocity.y < 0)
            {
                rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
            }
            else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
            {
                rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
            }

        }
    }
}

