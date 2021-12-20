using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class describes my aceleration.
/// </summary>
public class MyAceleration : MonoBehaviour {
// Move object using accelerometer
    float speed = 10.0f;

    /// <summary>
    /// Updates the object.
    /// </summary>
    void Update() {

        Vector3 dir = Vector3.zero;

        // we assume that device is held parallel to the ground
        // and Home button is in the right hand

        // remap device acceleration axis to game coordinates:
        //  1) XY plane of the device is mapped onto XZ plane
        //  2) rotated 90 degrees around Y axis
        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;
        Debug.Log("Acelerómetro: \n\t- x:" + Input.acceleration.x + "\n\t- z: " + Input.acceleration.z);

        // clamp acceleration vector to unit sphere
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        // Make it move 10 meters per second instead of 10 meters per frame...
        dir *= Time.deltaTime;

        // Move object
        transform.Translate(dir * speed);
    }
}
