using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapScreenLate : MonoBehaviour
{
    public GameObject schoolButton;
    public timeValue worldTime;
    void Start()
    {
        if (worldTime.Hour > 17 || worldTime.Hour < 4){
            schoolButton.SetActive(false);
        } else {schoolButton.SetActive(true);}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
