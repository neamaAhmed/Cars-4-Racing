using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav : MonoBehaviour {
    public Transform TargetPoint1;
    public Transform TargetPoint2;
    public NavMeshAgent myAg;
    //private Transform position1;
    public bool Arrived2flag1 = false;
    public float mytime = 100;
    // Use this for initialization
    void Start () {
        myAg.SetDestination(TargetPoint1.position);
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Enter");
        if (transform.position == TargetPoint1.position)
        {
            Debug.Log("Exit");
            myAg.SetDestination(TargetPoint2.position);

        }
        //else
        //{
        //    myAg.SetDestination(TargetPoint2.position);
        //    Debug.Log("Exit");
        //    Arrived2flag1 = false;
        //}
        //mytime -= 1 * Time.deltaTime;
        //Debug.Log(mytime);
        //GetComponent<Rigidbody>().velocity *= 2 ^ 2;
        if (mytime <= 0)
        {
            //CarControl.GetComponent<Rigidbody>().velocity /= 2 ^ 5;
            Debug.Log("Returned");
        }
    }
}
