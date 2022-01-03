using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    [SerializeField] bool go_left = true;
    [SerializeField] float leftmost;
    [SerializeField] float rightmost;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xpos = transform.position.x;

        if (xpos > leftmost)
            go_left = false;
        if (xpos < rightmost)
            go_left = true;


        if (go_left)
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        if (!go_left)
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
    }
    
}
