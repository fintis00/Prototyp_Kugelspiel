using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    [SerializeField]
    public GameObject npc;

    private void Start()
    {
        LeanTween.moveX(npc, 1, 5).setEaseInOutSine().setLoopPingPong();
    }
}
