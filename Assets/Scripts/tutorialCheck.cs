using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class tutorialCheck : MonoBehaviour
{
    public boolValue tutorialStatus;
    public bool turnOffThisTutorial;
    public UnityEvent interactAction;
    void Start()
    {
        if (tutorialStatus.initialValue == true){
            interactAction.Invoke();
        }
        if (turnOffThisTutorial == true){
            tutorialStatus.initialValue = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
