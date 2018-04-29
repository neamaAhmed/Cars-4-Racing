using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav : MonoBehaviour {
    public Transform TargetPoint1;
    public Transform TargetPoint2;
    //public NavMeshAgent myAg;
    //private Transform position1;
    public bool Arrived2flag1 = false;
    // Use this for initialization
    public Transform[] destinations;
    public int currentTarget = 0;
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(destinations[0].position);
    }

    void Update()
    {
        //Debug.Log("Inside Second If3 ");
        float dist = Vector3.Distance(this.transform.position, destinations[currentTarget].position);
        if (dist <= 10)
        {
            
            Debug.Log(currentTarget);
            if (currentTarget == 2)
            {
                currentTarget = 0;
                Debug.Log("Zeroooo");
            }
            agent.SetDestination(destinations[currentTarget].position); // set next target
            currentTarget++;
        }
        
        //Debug.Log("Inside First If ");
        //Debug.Log(currentTarget);
        // Use this if statement condition if you want your AI to patrol
        //if (currentTarget >= destinations.Length - 1)
        //{
        //    currentTarget = 0;  // reset current target
        //    agent.SetDestination(destinations[currentTarget].position);
        //    Debug.Log("Inside First If2 ");
        //}

        ////// this if statement controls the AI to navigate to different destinations
        //if (currentTarget < destinations.Length - 1)
        //{

        //}
    }
    //void Start () {
    //    myAg.SetDestination(TargetPoint1.position);
    //}
	
	// Update is called once per frame
	//void Update () {
 //       //Debug.Log("Enter");
 //       if (transform.position == TargetPoint1.position)
 //       {
 //           Debug.Log("Exit");
 //           myAg.SetDestination(TargetPoint2.position);

 //       }
        //else
        //{
        //    myAg.SetDestination(TargetPoint2.position);
        //    Debug.Log("Exit");
        //    Arrived2flag1 = false;
        //}
        //mytime -= 1 * Time.deltaTime;
        //Debug.Log(mytime);
        //GetComponent<Rigidbody>().velocity *= 2 ^ 2;
    //    if (mytime <= 0)
    //    {
    //        //CarControl.GetComponent<Rigidbody>().velocity /= 2 ^ 5;
    //        Debug.Log("Returned");
    //    }
    //}
}
