using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dreamcar01TrickerTemp : MonoBehaviour {

    public GameObject tricker;
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Car;
    public int MarkTricker;
   // public bool check = false;

    // Update is called once per frame
    void Update()
    {
        if (MarkTricker == 0)
        {
            tricker.transform.position = Mark01.transform.position;
            //check = true;
            //Debug.Log("Colider1");
        }
        if (MarkTricker == 1)
        {
            tricker.transform.position = Mark02.transform.position;
        }
        if (MarkTricker == 2)
        {
            tricker.transform.position = Mark03.transform.position;
        }
        if (MarkTricker == 3)
        {
            tricker.transform.position = Mark04.transform.position;
        }
        if (MarkTricker == 4)
        {
            tricker.transform.position = Mark05.transform.position;
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        //Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Untagged")
        {
            //Debug.Log(collision.gameObject.tag);
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTricker += 1;
            if (MarkTricker == 5)
            {
                MarkTricker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
            /////
            //Car.GetComponent<Rigidbody>().velocity *= 2 ^ 5;
            //Debug.Log(Car.GetComponent<Rigidbody>().velocity *= 2 ^ 5);



            //Debug.Log(Car.GetComponent<Rigidbody>().velocity.magnitude * 2.23693629f);
            // yield return new WaitForSeconds(2);
            //Car.GetComponent<Rigidbody>().velocity /= 2 ^ 5;
            //Debug.Log(Car.GetComponent<Rigidbody>().velocity.magnitude * 2.23693629f);
        }
    }
}
