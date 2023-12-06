using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilestoneDetection : MonoBehaviour
{
    public intValue playerLevel;
    public floatValue pInfluence;

    void Start()
    {

        switch (pInfluence.initialValue){
            case 0:
                playerLevel.initialValue = 0;
                break;
            case 200:
                playerLevel.initialValue = 1;
                break;
            case 700:
                playerLevel.initialValue = 2;
                break;
            case 1300:
                playerLevel.initialValue = 3;
                break;
        }

    }

}
