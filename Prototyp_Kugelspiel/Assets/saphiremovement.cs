using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saphiremovement : MonoBehaviour
{

    public GameObject camera;

    public GameObject endScreen;
    public GameObject player;
    

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y == -2)
        {
            endScreen.SetActive(true);
            

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CustomTags>().HasTag("Player"))
        {
            camera.GetComponent<TPSCamera>().Character = gameObject;
            LeanTween.moveY(gameObject, -2, 5).setEaseInOutSine();
        }
    }
}
