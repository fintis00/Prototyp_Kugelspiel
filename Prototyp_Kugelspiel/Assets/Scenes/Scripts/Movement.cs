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

        ramp = false;
        rb.drag = 4;
        if (collision.gameObject.GetComponent<CustomTags>().HasTag("Rampe"))
        {
            ramp = true;
            rb.drag = 4;
        }
        if (collision.gameObject.GetComponent<CustomTags>().HasTag("Platte"))
        {
            rb.drag = 4;
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

        
        Vector3 impulse = (camF * yInput + camR * xInput) * Time.deltaTime * speed;
        impulse = impulse * speed;

        if (!rb.GetComponent<Jumping>().getJumpable())
        {
            impulse *= 0.8f;
        }
        rb.AddForce(impulse);
    }
}

