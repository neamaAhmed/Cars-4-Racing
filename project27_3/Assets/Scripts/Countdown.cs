﻿//Jimmy Vegas Unity 5 Tutorial
//These scripts will countdown to the race and set controls active


// Countdown script

using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Countdown : MonoBehaviour
{

    public GameObject CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject CarControls;
    public bool EnableCarController = false;
    public GameObject car;
    void Start()
    {
        
        StartCoroutine(CountStart());
    }


    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text>().text = "3";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "1";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        GoAudio.Play();
        LapTimer.SetActive(true);
        //CarControls.SetActive(true);
        car.GetComponent<CarController>().enabled = true;
        car.GetComponent<CarUserControl>().enabled = true;
    }


}
