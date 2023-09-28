using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilestoneDetection : MonoBehaviour
{
    public intValue playerLevel;
    public switchScene sceneTrigger;

    void Start()
    {
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
