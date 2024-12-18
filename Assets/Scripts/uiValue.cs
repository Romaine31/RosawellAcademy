using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uiValue : MonoBehaviour
{
    public intValue pMoney;
    public floatValue pInfluence;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI influenceText;

    void Update()
    {
        updateMoney();
        updateInfluence();
    }

    void updateMoney()
    {
        moneyText.text = $"{pMoney.initialValue:00}";
    }

    void updateInfluence()
    {
        influenceText.text = $"{pInfluence.initialValue:00}";
    }
}
