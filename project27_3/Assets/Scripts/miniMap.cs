using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniMap : MonoBehaviour {

    public Transform Car;
    void track()
    {
        Vector3 newPosition = Car.position;
        newPosition.y = transform.position.y;
        newPosition.x = transform.position.x;
        newPosition.z = transform.position.z;
        transform.position = newPosition;
    }
}
