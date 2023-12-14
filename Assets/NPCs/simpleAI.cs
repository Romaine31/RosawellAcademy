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
    public Animator animator;
     public Vector3 target;
     Vector2 movement;
     public npcDataHolder npcInfo;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        aiScheduler = GetComponent<scheduleAI>();
        npcInfo = GetComponent<npcDataHolder>();
        animator = npcInfo.npcAnimator;
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
        target = aiScheduler.destinationReference.transform.position;
        if (target.x < agent.transform.position.x){
            movement.x = -1;
        } else { movement.x = 1; }
        if (target.y < agent.transform.position.y){
            movement.y = -0.5f;
        } else { movement.y = 0.5f;}
        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical",movement.y);
        animator.SetFloat("Speed",movement.magnitude);
        
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
