﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carStable : MonoBehaviour {
    public GameObject Car;
    public float carX;
    public float carY;
    public float carZ;


    // Update is called once per frame
    void Update () {
        carX = Car.transform.eulerAngles.x;
        carY = Car.transform.eulerAngles.y;
        carZ = Car.transform.eulerAngles.z;

    }
}
