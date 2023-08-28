using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class simpleAI : MonoBehaviour
{
    [SerializeField] Transform targer;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update()
    {
        agent.SetDestination(targer.position);
    }
}
