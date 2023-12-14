using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueTrigger : MonoBehaviour
{
    public Message[] messages;
    public string randMsg;
    public stringList npcGenMessages;
    public void StartDialogue()
    {
        FindObjectOfType<dialogueManager>().OpenDialogue(messages);
    }
    // public void StartDialogueRandom(){
    //     var x = Random.Range(0, npcGenMessages.messages.Length);
    //     randMsg = npcGenMessages.messages[x];
    //     FindObjectOfType<dialogueManager>().OpenDialogue(randMsg);
    // }
    
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

