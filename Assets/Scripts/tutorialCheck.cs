using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class tutorialCheck : MonoBehaviour
{
    public boolValue tutorialStatus;
    public UnityEvent interactAction;
    void Start()
    {
        if (tutorialStatus == true){
            interactAction.Invoke();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
