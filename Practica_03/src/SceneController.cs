/*
* @Author: Adrian Epifanio
* @Date:   2021-10-30 20:49:02
* @Last Modified by:   Adrian Epifanio
* @Last Modified time: 2021-10-30 20:50:33
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate bool detectCollisionWithA();
public delegate void changeColorCylinderB();
public delegate void rotateSphereTo();

/// <summary>
/// Controls the data flow into a scene object and updates the view whenever data changes.
/// </summary>
public class SceneController : MonoBehaviour {
    
    public static event detectCollisionWithA detectCollisionA;
    public static event changeColorCylinderB colorCylinderB;
    public static event rotateSphereTo rotateSphere;
    public float distanceMedium;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start () {
        distanceMedium = 5f;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update ()  {
        if (detectCollisionA()) {
            colorCylinderB();
            rotateSphere();
        }
    }
}