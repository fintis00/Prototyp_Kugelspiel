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
    [SerializeField]
    GameObject player;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

   

    
    void FixedUpdate()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        
        if (!player.GetComponent<Jumping>().grounded)
        {
            if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
            {
                rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
            }

        }
    }
}

