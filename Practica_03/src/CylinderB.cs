/*
* @Author: Adrian Epifanio
* @Date:   2021-10-30 20:49:02
* @Last Modified by:   Adrian Epifanio
* @Last Modified time: 2021-10-30 20:50:29
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class describes a cylinder of type b.
/// </summary>
public class CylinderB : MonoBehaviour {

    private Renderer target;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>    
    void Start () {
        target = GetComponent<Renderer>();
        SceneController.colorCylinderB += changeColor;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {     
    }

    /// <summary>
    /// Changes the color of the cylinder to a random one
    /// </summary>
    public void changeColor () {
        Debug.Log("Color changed");
        target.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
