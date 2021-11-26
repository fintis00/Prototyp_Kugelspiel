using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 15f;

    // Start is called before the first frame update
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private bool ramp = false;

    public Transform cam;

    private float xInput;
    private float yInput;

    private float mult_ramp = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<CustomTags>().HasTag("Hindernis"))
        {
            ramp = false;
            rb.GetComponent<realisticJump>().fallMultiplier = 5;
        }
        else if (collision.gameObject.GetComponent<CustomTags>().HasTag("Ground"))
        {
            ramp = false;
            rb.GetComponent<realisticJump>().fallMultiplier = 5;
        }
        else if (collision.gameObject.GetComponent<CustomTags>().HasTag("Rampe"))
        {
            ramp = true;
            rb.GetComponent<realisticJump>().fallMultiplier = 5;
        }
        if (ramp)
        {
            mult_ramp = 1.5f;
            rb.drag = 4;
        }
        else
        {
            rb.drag = 5;
            mult_ramp = 1f;

        }
    }

    private void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;

        camF.y = 0;
        camR.y = 0;

        camF = camF.normalized;
        camR = camR.normalized;

        if (ramp && rb.velocity.y < 0)
        {
            mult_ramp = 0.8f;
        }
        else
        {
            mult_ramp = 1f;
        }
        Vector3 impulse = (camF * yInput + camR * xInput) * Time.deltaTime * speed;
        impulse = impulse * speed * mult_ramp;

        if (!rb.GetComponent<Jumping>().getJumpable())
        {
            impulse *= 0.8f;
        }
        rb.AddForce(impulse);
    }
}

