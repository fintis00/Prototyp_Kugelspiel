using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_move_up_down : MonoBehaviour
{
    [SerializeField] bool go_up = false;
    [SerializeField] float floor;
    [SerializeField] float ceiling;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float ypos = transform.position.y;

        if (ypos >= ceiling)
            go_up = !go_up;

        if (ypos <= floor)
            go_up = !go_up;


        if (go_up)
            transform.position = new Vector3(transform.position.x, ypos + 1f * Time.deltaTime, transform.position.z);
        else
            transform.position = new Vector3(transform.position.x, ypos - 1f * Time.deltaTime, transform.position.z);




    }
}