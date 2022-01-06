using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{

    public int[] scores;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        scores = new int[6];
        PlayerPrefs.DeleteAll();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
