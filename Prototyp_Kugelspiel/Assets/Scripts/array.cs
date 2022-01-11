using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{

    public int[] scores;
    // Start is called before the first frame update
    private void Start()
    {
        
        FindObjectOfType<AudioManager>().Play("Hauptmenu");
        
        scores = new int[6];
        
        DontDestroyOnLoad(gameObject);
        
        
    }

    
}
