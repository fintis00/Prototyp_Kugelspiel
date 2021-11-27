using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour
{
    private float xInput;
    private float yInput;
    private Rigidbody rb;
    public float dashspeed;
    private float dashTime;
    public float startDashTime;
    private int direction;

    [SerializeField]
    public Transform cam;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        dashTime = startDashTime;
    }

    private void Update()
    {
        
        yInput = Input.GetAxis("Vertical");

        Vector3 camF = cam.forward;
        camF.y = 0;

        camF = camF.normalized;
        if (!rb.GetComponent<realisticJump>().getGrounded())
        {
            
             if (Input.GetKeyDown(KeyCode.E)) {               
                if (dashTime <= 0)
                {
                    direction = 0;
                    dashTime = startDashTime;
                    rb.velocity = Vector3.zero;
                }
                else
                {
                    rb.velocity = camF.z * Vector3.forward * dashspeed;
                    dashTime -= Time.deltaTime;
                    
                }
            }
        }
    }

}
