using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaToggle : MonoBehaviour
{
    public boolValue barricadestatus;
    public intValue playerMoney;
    // Start is called before the first frame update
    void Start()
    {
        if (barricadestatus.initialValue == false)
        {
            removeBarricade();
        }
    }

    public void removeBarricade()
    {
        barricadestatus.initialValue = false;
        Destroy(gameObject);
    }
}
