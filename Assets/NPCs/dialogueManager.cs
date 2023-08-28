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
    Actor[] currentActors;
    int activeMessage = 0;
    public static bool isActive = false;


    public void OpenDialogue(Message[] messages, Actor[] actors)
    {
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;
        Debug.Log("started conversation! Loaded messages: " + messages.Length);
        DisplayMessage();
        backgroundBox.LeanScale(Vector3.one, 0.5f);
    }

    public void NextMessage()
    {
        activeMessage++;
        if (activeMessage < currentMessages.Length-1)
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

        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
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
