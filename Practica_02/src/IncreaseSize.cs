/*
* @Author: Adrian Epifanio
* @Date:   2021-10-22 10:28:47
* @Last Modified by:   Adrian Epifanio
* @Last Modified time: 2021-10-25 08:34:07
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class describes an increase size.
/// </summary>
public class IncreaseSize : MonoBehaviour {

    MyCharacterController player_; // Reference to the player cube

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start() {
        player_ = GameObject.FindGameObjectWithTag("Player").GetComponent<MyCharacterController>();
    }

    /// <summary>
    /// Updates the object.
    /// </summary>
    void Update () {
    }

    /// <summary>
    /// Called on collision stay.
    /// Increase the size of the element if it's on collision state and incrase player points
    /// </summary>
    ///
    /// <param name="other">The other</param>
    private void OnCollisionStay(Collision other) {
        if (other.gameObject.tag == "Player") {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.y) * 1.005f;
            player_.increasePoint();
        }
    }
}
