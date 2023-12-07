using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeSkip : MonoBehaviour
{
    public timeValue worldTime;
    public int lessonSkip = 3;// hour
    public int travelSkip = 0;// mins
    public bool inLesson;
    
    void OnDestroy()
    {
        if (inLesson == true)
        {
            worldTime.Hour += lessonSkip;
        } else if (inLesson == false)
        {
            worldTime.Minute += travelSkip;
        }
    }
}
