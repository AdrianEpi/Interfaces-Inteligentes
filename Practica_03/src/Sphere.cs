/*
* @Author: Adrian Epifanio
* @Date:   2021-10-30 20:49:02
* @Last Modified by:   Adrian Epifanio
* @Last Modified time: 2021-10-30 20:50:35
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class describes a sphere.
/// </summary>
public class Sphere : MonoBehaviour {

    public GameObject target;
    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start () {
        SceneController.rotateSphere += lookAt;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
        // Debugging lines to know which direction is pointing the sphere
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
    }

    /// <summary>
    /// Rotates the sphere to the target object
    /// </summary>
    public void lookAt () {
        Debug.Log("Rotated");
        transform.LookAt(target.transform);
    }
}
