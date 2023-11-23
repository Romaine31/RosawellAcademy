using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class simpleAI : MonoBehaviour
{
    NavMeshAgent agent;
    
    private scheduleAI aiScheduler;
    public bool isCurrentlyWandering = false;
    [Range(1,100)] public float walkRadius;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        aiScheduler = GetComponent<scheduleAI>();
    }


    void Update()
    {
        isCurrentlyWandering = aiScheduler.wanderCheck;
        try{
            agent.SetDestination(aiScheduler.destinationReference.transform.position);
            if (isCurrentlyWandering == true){
                agent.SetDestination(npcWander());
            } else {agent.SetDestination(aiScheduler.destinationReference.transform.position);}
        }
        catch{
            Debug.Log("no destination set yet");
        }
    }
    
    Vector2 npcWander() {
        Vector3 finalPosition = Vector3.zero;
        Vector3 randomPosition = Random.insideUnitCircle * walkRadius;
        randomPosition += transform.position;
        if(NavMesh.SamplePosition(randomPosition, out NavMeshHit hit, walkRadius, 1))
        {
            finalPosition = hit.position;
        }
        return finalPosition;
    }
}
