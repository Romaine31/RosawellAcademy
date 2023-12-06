using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueTrigger : MonoBehaviour
{
    public Message[] messages;

    public void StartDialogue()
    {
        FindObjectOfType<dialogueManager>().OpenDialogue(messages);
    }
    
}
    [System.Serializable]
    public class Message 
    {
        public string message;
    }

    // [System.Serializable]
    // public class Actor
    // {
    //     public string name;
    // }

