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
    public timeValue worldTime;
    public GameObject doorWay;

    void Start()
    {
          if(worldTime.Hour >= 19)
        {
            doorWay.SetActive(true);
        } else { doorWay.SetActive(false); }
    }

    void Update()
    {
        
    }

    public void computeCurrency()
    {
        if (currentLvl.initialValue == 0)
        {
            for (int i = 0; i < npcValues.npcValues.Length; i++)
            {
                totalNpcMultiplier += npcValues.npcValues[i].multiplier;
            }
            totalNpcMultiplier *= 0.2f;
        }
        else if (currentLvl.initialValue == 1)
        {
            for (int i = 0; i < npcValues.npcValues.Length; i++)
            {
                totalNpcMultiplier += npcValues.npcValues[i].multiplier;
            }
            totalNpcMultiplier *= 0.4f;
        }
        else if (currentLvl.initialValue == 2)
        {
            for (int i = 0; i < npcValues.npcValues.Length; i++)
            {
                totalNpcMultiplier += npcValues.npcValues[i].multiplier;
            }
            totalNpcMultiplier *= 0.5f;
        }
        else if (currentLvl.initialValue == 3)
        {
            for (int i = 0; i < npcValues.npcValues.Length; i++)
            {
                totalNpcMultiplier += npcValues.npcValues[i].multiplier;
            }
            totalNpcMultiplier *= 0.6f;
        }

        pInfluence.initialValue *= totalNpcMultiplier;
        pCurrency.initialValue = (int)pInfluence.initialValue / 2;
    }
}
