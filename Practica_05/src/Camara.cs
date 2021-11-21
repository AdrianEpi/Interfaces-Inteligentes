using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class describes a camara.
/// </summary>
public class Camara : MonoBehaviour {

    private WebCamTexture webcam;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start() {
        if (webcam == null) 
            webcam = new WebCamTexture();
        GetComponent<Renderer>().material.mainTexture = webcam;
        if (!webcam.isPlaying)
            webcam.Play();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update() {      
    }
}
