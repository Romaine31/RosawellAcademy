using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scheduleAI : MonoBehaviour
{
    public intValue schedStorage;
    public timeValue currentTime;
    //public GameObject scheduleHolder;
    public npcDestinationDirector destination;
    public int nextSchedule;
    public int roomDestinationIndex;
    public int areaDestinationIndex; //gets the exact location
    public GameObject destinationReference;
    public bool wanderCheck;
    public scheduler[] schedule;
    public int testValue;
    // Start is called before the first frame update
    [System.Serializable]
    public class scheduler{
        public int scheduleTimeHour;
        public int scheduleTimeMinute;
        public int desiredRoomIndex;
        public bool allowWander;
    }
    void Awake()
    {
        nextSchedule = schedStorage.initialValue;
        //roomDestinationIndex = 0;
        //scheduleHolder = GameObject.FindGameObjectWithTag("npcScheduler");
        destination = GameObject.FindGameObjectWithTag("npcScheduler").GetComponent<npcDestinationDirector>();
        //goalDestination = destination.npcNumber[0].gameObjectLocations[0].currentDestination.transform.position;
    }

    // Update is called once per frame
    
    void Update()
    {
        if(currentTime.Hour >= schedule[nextSchedule].scheduleTimeHour & currentTime.Hour < schedule[nextSchedule+1].scheduleTimeHour+1 & currentTime.Minute >= schedule[nextSchedule].scheduleTimeMinute & currentTime.Minute < 60){
            schedStorage.initialValue = nextSchedule;
            roomDestinationIndex = schedule[nextSchedule].desiredRoomIndex;
            areaDestinationIndex = Random.Range(0, destination.roomNumber[roomDestinationIndex].gameObjectLocations.Count);
            destinationReference = destination.roomNumber[roomDestinationIndex].gameObjectLocations[areaDestinationIndex].currentDestination;
            wanderCheck = schedule[nextSchedule].allowWander;
            Debug.Log(schedule[nextSchedule]);
            nextSchedule++;
        }
    }
}