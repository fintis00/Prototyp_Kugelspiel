using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationTest : MonoBehaviour
{
    [SerializeField]
    public GameObject npc;
    public GameObject cube1;
    public GameObject cube2;

    // Start is called before the first frame update
    private void Start()
    {
        LeanTween.moveX(npc, 1, 5).setEaseInOutSine().setLoopPingPong();
        LeanTween.moveX(cube1, 6, 3).setEaseInOutSine().setLoopPingPong();
        LeanTween.moveX(cube2, 6, 3).setEaseInOutSine().setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
