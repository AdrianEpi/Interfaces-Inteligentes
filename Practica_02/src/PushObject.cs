/*
* @Author: Adrian Epifanio
* @Date:   2021-10-22 10:39:04
* @Last Modified by:   Adrian Epifanio
* @Last Modified time: 2021-10-25 08:37:48
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class describes a push object.
/// </summary>
public class PushObject : MonoBehaviour {

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start (){       
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {        
    }

    /// <summary>
    /// Called on collision stay.
    /// Looks if the cube (player) is collisioning with the object, if it is, the object moves to the right
    /// </summary>
    ///
    /// <param name="other">The other</param>
    private void OnCollisionStay (Collision other) {
        if (other.gameObject.tag == "Player" && Input.GetKey(KeyCode.Space)) {
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        }
    }
}
