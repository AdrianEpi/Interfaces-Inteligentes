/*
* @Author: Adrian Epifanio
* @Date:   2021-10-10 10:18:21
* @Last Modified by:   Adrian Epifanio
* @Last Modified time: 2021-10-10 10:19:12
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printLog : MonoBehaviour
{
    int aux = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Se crea el objeto " + this.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.name + " actualiza iteración " + aux);
        aux++;
    }
}
