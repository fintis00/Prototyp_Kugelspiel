using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions_dialog : MonoBehaviour
{
    public Dialogue dialogue;

    public void instructions(Dialogue dialogue)
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
