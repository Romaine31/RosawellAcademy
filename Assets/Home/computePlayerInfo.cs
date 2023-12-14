using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computePlayerInfo : MonoBehaviour
{
    public floatValue pInfluence;
    public intValue pCurrency;
    public float totalMultiplier;
    public timeValue worldTime;
    public GameObject doorWay;
    public floatValue playerMulti;

    void Start()
    {
          if(worldTime.Hour >= 19)
        {
            doorWay.SetActive(true);
        } else { doorWay.SetActive(false); }
        totalMultiplier = playerMulti.initialValue;
    }

    void Update()
    {

    }

    public void computeCurrency()
    {

        pInfluence.initialValue *= totalMultiplier;
        pCurrency.initialValue = (int)pInfluence.initialValue / 2;
    }
}
