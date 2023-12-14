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
    public string currentActor;
    public int activeMessage = 0;
    
    public static bool isActive = false;
    public bool isActiveCheck;


    public void OpenDialogue(Message[] messages)
    {
        currentMessages = messages;
        // if (gameObject.tag == "students"){
        // currentActor = GetComponent<npcDataHolder>().npcName;

        // }
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
            // backgroundBox.SetActive(false);
            // isActive = false;
            // actorName.SetActive(false);
            // messageText.SetActive(false);
        }

    }

    void DisplayMessage()
    {
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;
        backgroundBox.SetActive(true);

        //actorName.text = currentActor;
        actorName.text = currentActor;
    }

    void Start()
    {

    }


    void Update()
    {
        isActiveCheck = isActive;
        if (Input.GetKeyDown(KeyCode.E) && isActive == true)
        {
            NextMessage();
        }
        // if (isActive == true){
        //    StartCoroutine(dialogueActive());
        // } else {Time.timeScale = 1;}
    }

    IEnumerator  notActive()
    {
        yield return new WaitForSeconds(0.5f);
        backgroundBox.SetActive(false);
        isActive = false;
    }
}
