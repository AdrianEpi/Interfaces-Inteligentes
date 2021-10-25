/*
* @Author: Adrian Epifanio
* @Date:   2021-10-22 11:24:32
* @Last Modified by:   Adrian Epifanio
* @Last Modified time: 2021-10-25 08:28:36
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class describes a flee away movement.
/// </summary>
public class FleeAway : MonoBehaviour {

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start () {     
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {       
    }

    /// <summary>
    /// Called on collision stay.
    /// Looks if the cube (player) is collisioning with the object, if it is, the object flees away.
    /// </summary>
    ///
    /// <param name="other">The other</param>
    private void OnCollisionStay (Collision other) {
        if (other.gameObject.tag == "Player") {
            float distance = 1f;
            if (transform.position.x < other.transform.position.x) {
                transform.position = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);
            }
            else if (transform.position.x > other.transform.position.x) {
                transform.position = new Vector3(transform.position.x - distance, transform.position.y, transform.position.z);
            }
            else if (transform.position.z < other.transform.position.z) {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - distance);
            }
            else if (transform.position.z > other.transform.position.z) {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + distance);
            }
        }
    }
}
