/*
* @Author: Adrian Epifanio
* @Date:   2021-10-30 20:49:02
* @Last Modified by:   Adrian Epifanio
* @Last Modified time: 2021-10-30 20:50:32
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class describes a player.
/// </summary>
public class Player : MonoBehaviour {
    
    public ObjectA objetoA;
    public ObjectB objetoB;
    private bool colisionWithA;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start() {
        SceneController.detectCollisionA += isColision;
        colisionWithA = false;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update() {
    }

    /// <summary>
    /// Called on collision enter.
    /// </summary>
    ///
    /// <param name="collision">The collision</param>
    private void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.tag == "ObjectA") {
            objetoB.increaseCounter();
        }
        else if (collision.gameObject.tag == "ObjectB") {
            objetoA.showText();
        }
        else if (collision.gameObject.tag == "CylinderA") {
            colisionWithA = true;
        }
    }
    
    /// <summary>
    /// Determines if colision.
    /// </summary>
    ///
    /// <returns>True if colision, False otherwise.</returns>
    private bool isColision () {
        if (colisionWithA) {
            colisionWithA = false;
            return true;
        } 
        else {
            return false;
        }
    }
}