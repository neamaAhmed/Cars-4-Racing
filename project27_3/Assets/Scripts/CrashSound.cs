using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

[RequireComponent(typeof(AudioSource))]
public class CrashSound : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        //Debug.Log("Crashed");
        //CarController.speed = 1000;
        //Debug.Log(CarController.speed); 
        audioSource.PlayOneShot(impact, 0.7F);
    }
}