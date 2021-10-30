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
/// This class describes an object b.
/// </summary>
public class ObjectB : MonoBehaviour {
    
    private int counter;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>s
    void Start () {
        counter = 0;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
    }

    /// <summary>
    /// Increases the counter.
    /// </summary>
    public void increaseCounter () {
        counter++;
        Debug.Log("Fuerza del objeto B: " + counter);
    }
}
