using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaToggle : MonoBehaviour
{
    public boolList itemsBought;
    public List<GameObject> itemList;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x <itemsBought.storeItem.Count; x++){
            if (itemsBought.storeItem[x] == true && itemList[x] != null){
                itemList[x].SetActive(true);
            }
        }
    }

}
