using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogueManager : MonoBehaviour
{
    public TextMeshProUGUI actorName;
    public TextMeshProUGUI messageText;
    public RectTransform backgroundBox;

    Message[] currentMessages;
    string currentActor;
    public int activeMessage = 0;
    public static bool isActive = false;


    public void OpenDialogue(Message[] messages)
    {
        currentMessages = messages;
        //currentActor = GetComponent<npcDataHolder>().npcCurrentId.ToString();
        activeMessage = 0;
        isActive = true;
        Debug.Log("started conversation! Loaded messages: " + messages.Length);
        DisplayMessage();
    }

    public void NextMessage()
    {
        activeMessage++;
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else
        {
            StartCoroutine(notActive());
            backgroundBox.transform.localScale = Vector3.zero;
        }
    }

    void DisplayMessage()
    {
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;

        //actorName.text = currentActor;
        actorName.text = "test";
    }

    void Start()
    {
        backgroundBox.transform.localScale = Vector3.zero;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isActive == true)
        {
            NextMessage();
        }
    }

    IEnumerator notActive()
    {
        yield return new WaitForSeconds(1);
        isActive = false;
    }
}
