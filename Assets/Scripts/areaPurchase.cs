using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaPurchase : MonoBehaviour
{
    public boolValue boolToToggle;
    public intValue playerMoney;
    public int requiredValue;

    public void buyArea()
    {
        if (playerMoney.initialValue > requiredValue)
        {
            boolToToggle.initialValue = false;
            playerMoney.initialValue -= requiredValue;
        }
    }
}
