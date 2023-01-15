using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CowFollower : MonoBehaviour
{
    Transform goal;
    bool moving = false;
    bool patrolling = false;
    NavMeshAgent agent;
    int currentPatrolTarget = 1;
    public float proximity;
    public GameObject locationToGo1;
    public GameObject locationToGo2;
    public GameObject locationToGo3;
    public Animator cowAnim;
    Vector3 lastPos;


    void Start()
    {

        goal = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        Debug.Log("proximity :" + proximity);
    }

    private void Update()
    {
        if (Vector3.Distance(this.transform.position, lastPos) < 0.1)
        {
            moving = false;
            cowAnim.SetBool("Ischasing", false);
        }
        else
        {
            moving = true;
            cowAnim.SetBool("Ischasing", true);
        }


        if (Vector3.Distance(agent.transform.position, goal.position) > proximity && !patrolling) { // if we are too far cow doesn't follow player

            StartCoroutine(Patrol());

        }
        else
        { // if we are close cow follows
 
         if (Vector3.Distance(agent.transform.position, goal.position) < proximity)
            { 
            agent.destination = goal.position;
            }
        }
    }


    private IEnumerator Patrol()
    {

        patrolling = true;

        while(Vector3.Distance(agent.transform.position, goal.position) > proximity) {



            if (moving == false)
            {
                Debug.Log("currentPatrolTarget :" + currentPatrolTarget);
                //if cow is far away, cow patrols
                switch (currentPatrolTarget)
                {
                    case 1:

                        currentPatrolTarget = 2;
                        agent.destination = locationToGo1.transform.position;
                        //moving = true;
                        //cowAnim.SetBool("Ischasing", true);
                        break;
                    case 2:

                        currentPatrolTarget = 3;
                        agent.destination = locationToGo2.transform.position;
                        //moving = true;
                        //cowAnim.SetBool("Ischasing", true);
                        break;
                    case 3:

                        currentPatrolTarget = 1;
                        agent.destination = locationToGo3.transform.position;
                        //moving = true;
                        //cowAnim.SetBool("Ischasing", true);
                        break;
                }

            }



            lastPos = this.transform.position;
            yield return new WaitForSeconds(1);

        }


        patrolling = false;



    }



}