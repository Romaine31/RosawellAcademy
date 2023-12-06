using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class aiTest : MonoBehaviour
{
     private NavMeshAgent agent;
     public Animator animator;
     public Vector3 target;
     public Vector3 oldTarget;


     Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        // movement.x = Input.GetAxisRaw("Horizontal");
        // movement.y = Input.GetAxisRaw("Vertical");
        if (target.x < agent.transform.position.x){
            movement.x = -1;
        } else { movement.x = 1; }
        if (target.y < agent.transform.position.y){
            movement.y = -0.5f;
        } else { movement.y = 0.5f;}
        // movement.x = target.x * agent.transform.position.x;
        // movement.y = target.y * agent.transform.position.y;

        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical",movement.y);
        animator.SetFloat("Speed",movement.magnitude);

        if (Input.GetMouseButtonUp(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = 0;
            agent.destination = target;
        }
    }
}
