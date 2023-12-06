using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextDay : MonoBehaviour
{
    public timeValue worldTime;
    public void startNextDay(){
        worldTime.Hour = 6;
        worldTime.Minute = 30;
        worldTime.Day += 1;
    }
}
