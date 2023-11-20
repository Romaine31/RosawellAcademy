using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class simpleAI : MonoBehaviour
{
    NavMeshAgent agent;
    public scheduleAI scheduler;
    private scheduleAI aiScheduler;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        aiScheduler = GetComponent<scheduleAI>();
    }


    void Update()
    {
        try{
        agent.SetDestination(aiScheduler.destinationReference.transform.position);
        }
        catch{
            Debug.Log("no destination set yet");
        }
    }
}
