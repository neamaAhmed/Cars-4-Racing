//LAP COMPLETE SCRIPT

using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;
    public GameController gameController;
    public GameObject LapTimeBox;
    public GameObject LapCounter;
    public GameObject CarControl;
    public int LapsDone;
    //public float mytime = 1f; 
    void OnTriggerEnter()
    {
        
        if (LapTimeManager.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
        }

        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;
        LapCounter.GetComponent<Text>().text = "" + (LapsDone+1);
        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
        LapsDone += 1;

        //mytime -=1* Time.deltaTime;
        //CarControl.GetComponent<Rigidbody>().velocity *= 2 ^ 2;
        //if (mytime <= 0) {
        //    //CarControl.GetComponent<Rigidbody>().velocity /= 2 ^ 5;
        //    UnityEngine.Debug.Log("Returned");
        //}
        //CarController.speed = 1000;
        //UnityEngine.Debug.Log(CarControl.GetComponent<Rigidbody>().velocity.magnitude * 2.23693629f);
        //WaitForSeconds timer = new WaitForSeconds(2);
        if (LapsDone == 3)
        {
            //Debug.Log("Hola2 " + LapsDone);
            gameController.GameOver();
        }
        
   
    }

}