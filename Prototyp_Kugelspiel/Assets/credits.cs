using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class credits : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(gameObject,1650,12).setEaseInOutSine();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y == 1650)
        {
            SceneManager.LoadScene("Startmenu");      
        }
    }
}
