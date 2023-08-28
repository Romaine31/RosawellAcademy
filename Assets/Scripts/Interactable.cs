using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    void Start()
    {
        
    }

    void Update() // interacts
    {
        if (isInRange && dialogueManager.isActive == false)
        {
            if(Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision) // these two OnTrigger functions check if the player is in range of the interaction
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
        }
    }
}
