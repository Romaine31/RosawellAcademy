using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scheduleAI : MonoBehaviour
{
    private Vector2 goalDestination;
    public List<Vector2> destinations = new List<Vector2>();
    public timeValue currentTime;
    public List<int> scheduleTime = new List<int>();
    public int nextSchedule = 0;
    public int currentDestination = 0;
    // Start is called before the first frame update
    void Awake()
    {
        nextSchedule = 0;
        currentDestination = 0;
        goalDestination = destinations[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTime.Minute == scheduleTime[nextSchedule]){
            Debug.Log(scheduleTime[nextSchedule]);
            nextSchedule++;
            currentDestination++;
            goalDestination = destinations[currentDestination];
        }
    }
}
