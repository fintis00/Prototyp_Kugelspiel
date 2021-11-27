using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour
{
    private Rigidbody rb;
    public float dashspeed;
    private float dashTime;
    public float startDashTime;
    private int direction;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        dashTime = startDashTime;
    }

    private void Update()
    {
        if (!rb.GetComponent<realisticJump>().getGrounded())
        {
            if(direction == 0)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                    direction = 1;
                }
                else if (Input.GetKeyDown(KeyCode.RightArrow)) {
                    direction = 2;
                }
                else if (Input.GetKeyDown(KeyCode.UpArrow)) {
                    direction = 3;
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow)) {
                    direction = 4;
                }
            }
            else
            {
                if (dashTime <= 0)
                {
                    direction = 0;
                    dashTime = startDashTime;
                    rb.velocity = Vector3.zero;
                }
                else
                {
                    dashTime -= Time.deltaTime;
                    if (direction == 1)
                    {
                        rb.velocity = Vector3.left * dashspeed;
                    } else if (direction == 2) {
                        rb.velocity = Vector3.right * dashspeed;
                    } else if (direction == 3) {
                        rb.velocity = Vector3.forward * dashspeed;
                    } else if (direction == 4) {
                        rb.velocity = Vector3.back * dashspeed;
                    }
                }
            }
        }
    }

}
