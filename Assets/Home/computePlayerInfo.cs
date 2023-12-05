using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computePlayerInfo : MonoBehaviour
{
    public floatValue pInfluence;
    public intValue pCurrency;
    public npcDetail npcValues;
    public intValue currentLvl;
    public float totalNpcMultiplier;

    void Start()
    {
        if (currentLvl.initialValue == 0) { 
            for (int i = 0; i < npcValues.npcValues.Length; i++)
            {
                totalNpcMultiplier += npcValues.npcValues[i].multiplier;
            }
            totalNpcMultiplier /= 8;
        }  
    }

    void Update()
    {
        
    }
}
