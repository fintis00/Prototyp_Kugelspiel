using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saphiremovement : MonoBehaviour
{

    public GameObject cam;

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

    public void beenden()
    {
        cam.GetComponent<TPSCamera>().Character = player;
        endScreen.SetActive(false);
        SceneManager.LoadScene("Menu");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CustomTags>().HasTag("Player"))
        {
            FindObjectOfType<AudioManager>().Stop("Level1");
            FindObjectOfType<AudioManager>().Play("Level1_win");
            Debug.Log("Musik stop");
            cam.GetComponent<TPSCamera>().Character = gameObject;
            LeanTween.moveY(gameObject, -2, 4).setEaseInOutSine();
        }
    }

}
