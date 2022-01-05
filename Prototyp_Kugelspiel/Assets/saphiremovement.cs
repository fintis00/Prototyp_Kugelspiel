using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saphiremovement : MonoBehaviour
{

    public GameObject camera;

    public GameObject endScreen;
    public GameObject player;
    

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y == -3)
        {
            endScreen.SetActive(true);
            

        }
    }

    public void beenden()
    {
        camera.GetComponent<TPSCamera>().Character = player;
        endScreen.SetActive(false);
        SceneManager.LoadScene("Menu");

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CustomTags>().HasTag("Player"))
        {
            camera.GetComponent<TPSCamera>().Character = gameObject;
            LeanTween.moveY(gameObject, -3, 5).setEaseInOutSine();
        }
    }

}
