/*
* @Author: Adrian Epifanio
* @Date:   2021-10-22 11:59:08
* @Last Modified by:   Adrian Epifanio
* @Last Modified time: 2021-10-25 08:37:17
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class describes cube logics.
/// </summary>
public class CubeLogics : MonoBehaviour {

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
    /// Increase the size of the element if it's on collision with a sphere and reduces his size if it's in collision with player.
    /// </summary>
    ///
    /// <param name="other">The other</param>
    private void OnCollisionStay(Collision other) {
        if (other.gameObject.tag == "Player") {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.y) * 0.95f;
        }
        else if (other.gameObject.tag == "Sphere") {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.y) * 1.005f;
        }
    }
}
