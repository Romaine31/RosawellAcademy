using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaPurchase : MonoBehaviour
{
    public boolList boolToToggle;
    public intValue playerMoney;
    public int requiredValue;
    public int itemIndex;
    public GameObject currentItem;

    public void buyItem()
    {
        if (playerMoney.initialValue > requiredValue)
        {
            boolToToggle.storeItem[itemIndex] = true;
            playerMoney.initialValue -= requiredValue;
            Destroy(currentItem);
        }
    }
}
// anatomy model = 0
// whiteboard = 1
// beakers = 2
// microscope = 3
// globe = 4
// flasks = 5
// periodic table = 6
// alphabet = 7
// flag = 8
// map = 9