using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextDay : MonoBehaviour
{
    public timeValue worldTime;
    public void startNextDay(){
        worldTime.Hour = 7;
        worldTime.Minute = 00;
        worldTime.Day += 1;
    }
}
