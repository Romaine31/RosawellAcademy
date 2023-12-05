using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timeManager : MonoBehaviour
{
    public timeValue worldTime;
    private float minuteToRealtime = 5f;
    private float timer;
    public TextMeshProUGUI timeText;

    void Start()
    {
        timer = minuteToRealtime;
        UpdateClockUI();
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <=0)
        {
            worldTime.Minute++;
            if(worldTime.Minute >= 60)
            {
                worldTime.Hour++;
                worldTime.Minute = 0;
                if (worldTime.Hour >= 24)
                {
                    worldTime.Day++;
                    worldTime.Hour = 0;
                    if(worldTime.Day >= 30)
                    {
                        worldTime.Quarter++;
                        worldTime.Day = 0;
                    }
                }
            }
            timer = minuteToRealtime;
            UpdateClockUI();
        }
    }

    void UpdateClockUI()
    {
        timeText.text = $"{worldTime.Hour:00}:{worldTime.Minute:00}";
    }
}
