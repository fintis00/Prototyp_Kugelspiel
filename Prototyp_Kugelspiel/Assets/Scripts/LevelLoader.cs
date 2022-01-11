using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public int n;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //other.GetComponent<Rigidbody>().isKinematic = true;
            //Invoke("DropFunc", 1.0f);
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerPrefs.DeleteAll();
                PlayerPrefs.SetInt("Scene", n);
                Debug.Log(n);
                SceneManager.LoadScene(n);
                FindObjectOfType<AudioManager>().Stop("Hauptmenu");
                FindObjectOfType<AudioManager>().Play("Level" + (n));
                FindObjectOfType<AudioManager>().Play("Level" + n + "_background");
            }


        }
    }
}
