using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class areaPurchase : MonoBehaviour
{
    public boolList boolToToggle;
    public intValue playerMoney;
    public int requiredValue;
    public int itemIndex;
    public GameObject currentItem;
    public GameObject buyNotif;
    public Text buyText;

    void Start(){
        buyNotif.SetActive(false);
    }
    public void buyItem()
    {
        if (playerMoney.initialValue > requiredValue)
        {
            buyText.text = "You have bought" + gameObject.name;
            StartCoroutine(displayNotif());
            boolToToggle.storeItem[itemIndex] = true;
            playerMoney.initialValue -= requiredValue;
            Destroy(currentItem);
        } else {
            buyText.text = "you don't have enough money, Required: " + requiredValue;
            StartCoroutine(displayNotif());
        }
    }

    IEnumerator displayNotif(){
        buyNotif.SetActive(true);
        yield return new WaitForSeconds (3);
        buyNotif.SetActive(false);
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