using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour
{
    
    private Rigidbody rb;
    public float dashspeed;
    private float dashTime;
    public float startDashTime;

    [SerializeField]
    public Transform cam;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        dashTime = startDashTime;
    }

    private void Update()
    {
       

        Vector3 camF = cam.forward;
        
        camF.y = 0;
        
        camF = camF.normalized;
        if (!rb.GetComponent<Jumping>().grounded)
        {
            
<<<<<<< Updated upstream
             if (Input.GetKeyDown(KeyCode.LeftShift)) {               
=======
             if (Input.GetKeyDown(KeyCode.Q)) 
            {
                FindObjectOfType<AudioManager>().Play("dash");
>>>>>>> Stashed changes
                if (dashTime <= 0)
                {
                    
                    dashTime = startDashTime;
                    rb.velocity = Vector3.zero;
                }
                else
                {
                    Vector3 impulse = camF * dashspeed;
                    dashTime -= Time.deltaTime;
                    rb.velocity = impulse;
                }
            }
        }
    }

}
