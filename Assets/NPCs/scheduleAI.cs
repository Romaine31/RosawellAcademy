using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scheduleAI : MonoBehaviour
{
    public timeValue currentTime;
    //public GameObject scheduleHolder;
    public npcDestinationDirector destination;
    public List<int> scheduleTime = new List<int>();
    public int nextSchedule;
    public int roomDestinationIndex;
    public int areaDestinationIndex;
    public GameObject destinationReference;
    // Start is called before the first frame update
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
        if(currentTime.Minute == scheduleTime[nextSchedule]){
            areaDestinationIndex = Random.Range(0, destination.roomNumber[roomDestinationIndex].gameObjectLocations.Count - 1);
            destinationReference = destination.roomNumber[roomDestinationIndex].gameObjectLocations[areaDestinationIndex].currentDestination;

            Debug.Log(scheduleTime[nextSchedule]);
            nextSchedule++;
            roomDestinationIndex++;
        }
    }
}