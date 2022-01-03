using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikesmove : MonoBehaviour
{
    [SerializeField] bool go_up = false;
    [SerializeField] float floor;
    [SerializeField] float ceiling;
    [SerializeField] float speed;
    // Update is called once per frame
    void Update()
    {
        float ypos = transform.position.y;

        if (ypos >= ceiling)
        {
            go_up = !go_up;
        }
            

        if (ypos <= floor)
        {
            go_up = !go_up;
        }
            


        if (go_up)
            transform.position = new Vector3(transform.position.x, ypos + speed * Time.deltaTime, transform.position.z);
        else
            transform.position = new Vector3(transform.position.x, ypos - speed * Time.deltaTime, transform.position.z);
    }
}