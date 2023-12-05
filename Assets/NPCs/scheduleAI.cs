using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scheduleAI : MonoBehaviour
{
    public timeValue currentTime;
    //public GameObject scheduleHolder;
    public npcDestinationDirector destination;
    public int nextSchedule;
    public int roomDestinationIndex;
    public int areaDestinationIndex;
    public GameObject destinationReference;
    public bool wanderCheck;
    public scheduler[] schedule;
    // Start is called before the first frame update
    [System.Serializable]
    public class scheduler{
        public int scheduleTime;
        public bool allowWander;
    }
    void Awake()
    {
        nextSchedule = 0;
        roomDestinationIndex = 0;
        //scheduleHolder = GameObject.FindGameObjectWithTag("npcScheduler");
        destination = GameObject.FindGameObjectWithTag("npcScheduler").GetComponent<npcDestinationDirector>();
        //goalDestination = destination.npcNumber[0].gameObjectLocations[0].currentDestination.transform.position;
    }

    // Update is called once per frame
    
    void Update()
    {
        if(currentTime.Minute == schedule[nextSchedule].scheduleTime){
            areaDestinationIndex = Random.Range(0, destination.roomNumber[roomDestinationIndex].gameObjectLocations.Count);
            destinationReference = destination.roomNumber[roomDestinationIndex].gameObjectLocations[areaDestinationIndex].currentDestination;
            wanderCheck = schedule[nextSchedule].allowWander;
            Debug.Log(schedule[nextSchedule]);
            nextSchedule++;
            roomDestinationIndex++;
        }
    }
}