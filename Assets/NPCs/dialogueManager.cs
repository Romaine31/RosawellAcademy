using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogueManager : MonoBehaviour
{
    public TextMeshProUGUI actorName;
    public TextMeshProUGUI messageText;
    public GameObject backgroundBox;

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
        
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else
        {
            // StartCoroutine(notActive());
            isActive = false;
            backgroundBox.SetActive(false);
            // actorName.SetActive(false);
            // messageText.SetActive(false);
        }
        activeMessage++;
    }

    void DisplayMessage()
    {
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;
        backgroundBox.SetActive(true);

        //actorName.text = currentActor;
        actorName.text = "test";
    }

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isActive == true)
        {
            NextMessage();
        }
        // if (isActive == true){
        //    StartCoroutine(dialogueActive());
        // } else {Time.timeScale = 1;}
    }

    // IEnumerator dialogueActive()
    // {
    //     yield return new WaitForSeconds(3);
    //     Time.timeScale = 0;
    // }
}
