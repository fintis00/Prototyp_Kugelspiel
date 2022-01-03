using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluebutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        GameObject.Find("Cube").GetComponent<MovePlatform>().enabled = true;
        Destroy(gameObject);
    }
}
