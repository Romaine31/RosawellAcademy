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
                playerLevel.initialValue = 0;
                break;
            case 500:
                playerLevel.initialValue = 1;
                break;
            case 1000:
                playerLevel.initialValue = 2;
                break;
        }

    }

}
