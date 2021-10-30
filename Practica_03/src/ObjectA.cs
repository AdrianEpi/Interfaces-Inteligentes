/*
* @Author: Adrian Epifanio
* @Date:   2021-10-30 20:49:02
* @Last Modified by:   Adrian Epifanio
* @Last Modified time: 2021-10-30 20:50:30
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class describes an object a.
/// </summary>
public class ObjectA : MonoBehaviour{
    
    public GameObject objetA;

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
    /// Shows the text.
    /// </summary>
    public void showText () {
        Debug.Log("ObjetoA: Lorem Ipsum");
    } 
}
