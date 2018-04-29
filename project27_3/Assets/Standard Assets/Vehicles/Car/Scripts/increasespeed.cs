using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increasespeed : MonoBehaviour
{
    public bool start_decreasing = false;
    public float timeout = 3f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (start_decreasing) {
            timeout -= 1 * Time.deltaTime;
            if (timeout <= 0)
            {
                GetComponent<Rigidbody>().velocity /= 2 ^ 2;
                Debug.Log("speed decreased");
                timeout = 5;
                start_decreasing = false;
            }
        }
        
    }
    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "nitros")
        {
            Debug.Log(collision.gameObject.tag);
            GetComponent<Rigidbody>().velocity *= 2 ^ 3;
            Debug.Log(GetComponent<Rigidbody>().velocity.magnitude * 2.23693629f);
            //Debug.Log(GetComponent<Rigidbody>().velocity *= 2 ^ 5);
            start_decreasing = true;
            yield return new WaitForSeconds(1);
         }
    }
}