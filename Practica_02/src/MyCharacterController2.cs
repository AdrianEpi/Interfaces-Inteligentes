/*
* @Author: Adrian Epifanio
* @Date:   2021-10-22 11:37:21
* @Last Modified by:   Adrian Epifanio
* @Last Modified time: 2021-10-25 08:37:02
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class describes my character controller 2.
/// This CharacterController will be moved with (J,I,L,M) keys.
/// </summary>
public class MyCharacterController2 : MonoBehaviour {

    public float speed_; /// Units per second 5f (5 u/s)
    public CharacterController player_;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start () {
        player_ = gameObject.GetComponent<CharacterController>();
        speed_ = 5.0f;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
    }

    /// <summary>
    /// Function that calculates the movement of the player
    /// </summary>
    private void FixedUpdate () {
        if (Input.GetKey(KeyCode.I)) {
            player_.Move(Vector3.forward * speed_ * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.M)) {
            player_.Move(Vector3.back * speed_ * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.J)) {
            player_.Move(Vector3.left * speed_ * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.L)) {
            player_.Move(Vector3.right * speed_ * Time.deltaTime);
        }
    }

}
