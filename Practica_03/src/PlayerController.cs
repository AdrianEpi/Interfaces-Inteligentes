/*
* @Author: Adrian Epifanio
* @Date:   2021-10-22 10:12:20
* @Last Modified by:   Adrián Epifanio
* @Last Modified time: 2021-10-30 20:31:12
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Controls the data flow into my character object and updates the view whenever data changes.
/// </summary>
public class PlayerController : MonoBehaviour {

    private float x_;
    private float y_;
    private float z_;
    public float speed_; // Units per second 5f (5 u/s)
    public CharacterController player_;
    private int points_;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start () {
        player_ = gameObject.GetComponent<CharacterController>();
        speed_ = 5.0f;
        points_ = 0;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
        x_ = Input.GetAxis("Horizontal");
        z_ = Input.GetAxis("Vertical");
        // Use key "Q" to rotate to the right
        if (Input.GetKey(KeyCode.Q)) {
            y_ -= Time.deltaTime * 100;
            transform.rotation = Quaternion.Euler(0, y_, 0);
        } // Use key "E" to rotate to the right
        else if (Input.GetKey(KeyCode.E)) {
            y_ += Time.deltaTime * 100;
            transform.rotation = Quaternion.Euler(0, y_, 0);
        }
    }

    /// <summary>
    /// Function that calculates the movement of the player
    /// </summary>
    private void FixedUpdate () {
        player_.Move(new Vector3(x_, -0.5f, z_) * speed_ * Time.deltaTime);
    }

    /// <summary>
    /// Increases the player point.
    /// </summary>
    public void increasePoint() {
        points_++;
        Debug.Log("Puntuación: " + points_);
    }
}
