using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class describes my microphone.
/// </summary>
public class MyMicrophone : MonoBehaviour {
    public AudioSource fusRoDah;
    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start() {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = Microphone.Start("", true, 50, 44100);
        audioSource.Play();
    }
    
    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update() {
        fusRoDah();
    }

    /// <summary>
    /// If the z key is pressed, the player will shout "FUS RO DAH"
    /// </summary>
    void fusRoDah() {
        if (Input.GetKey(KeyCode.Z)) {
            fusRoDah.Play();
        }
    }
}
