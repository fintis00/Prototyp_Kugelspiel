using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationTest : MonoBehaviour
{
    [SerializeField]
    public GameObject npc;
    public GameObject npc1;
    public GameObject npc2;
    public GameObject npc3;

    public GameObject cube1;
    public GameObject cube2;

    // Start is called before the first frame update
    private void Start()
    {
        LeanTween.moveX(npc, -6, 6).setEaseInOutSine().setLoopPingPong();
        LeanTween.moveZ(npc1, 1, 7).setEaseInOutSine().setLoopPingPong();
        LeanTween.moveX(npc2, -2, 6).setEaseInOutSine().setLoopPingPong();
        LeanTween.moveX(npc3, -3, 6).setEaseInOutSine().setLoopPingPong();

        LeanTween.moveX(cube1, 7, 6).setEaseInOutSine().setLoopPingPong();
        LeanTween.moveX(cube2, 4, 6).setEaseInOutSine().setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
