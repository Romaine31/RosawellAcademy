using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilestoneDetection : MonoBehaviour
{
    public intValue playerLevel;
    public floatValue pInfluence;
    public switchScene sceneTrigger;

    void Start()
    {

        switch (pInfluence.initialValue){
            case 0:
                playerLevel.initialValue = 1;
                break;
            case 500:
                playerLevel.initialValue = 2;
                break;
            case 1000:
                playerLevel.initialValue = 3;
                break;
        }

        switch (playerLevel.initialValue){
            case 1:
                sceneTrigger.selectedScene = "School1";
                break;
            case 2:
                sceneTrigger.selectedScene = "School2";
                break;
            case 3:
                sceneTrigger.selectedScene = "School3";
                break;
        }
    }

}
