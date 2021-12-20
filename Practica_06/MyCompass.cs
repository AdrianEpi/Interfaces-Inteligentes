using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class describes my compass.
/// </summary>
public class MyCompass : MonoBehaviour {
    //GameObject camera;
    public GameObject brujulaGUI;
    private Text info;
    float smooth = 5.0f;

    // /// <summary>
    // /// Called when the program starts
    // /// </summary>
    // void Start () {
    //     camera = GameObject.Find("Main Camera");
    //     Input.location.Start();
    //     Input.compass.enabled = true;
    // }

    // /// <summary>
    // /// Updates the object.
    // /// </summary>
    // void Update() {
    //     Vector3 angles = camera.transform.rotation.eulerAngles;
    //     angles.y = Input.compass.trueHeading;
    //     camera.transform.rotation = Quaternion.Euler(angles);
    //     Debug.Log("Brújula: " + Input.compass.trueHeading.ToString() + generateDirection(Input.compass.trueHeading));
    // }
    // 
    
     void Update() {
        if (Input.location.status == LocationServiceStatus.Running) {
            Input.compass.enabled = true;
            Vector3 angles = brujulaGUI.transform.rotation.eulerAngles;
            angles.y = Input.compass.trueHeading;
            brujulaGUI.transform.rotation = Quaternion.Euler(angles);
            // Quaternion target = Quaternion.Euler(0, 0, Input.compass.trueHeading);
            // brujulaGUI.transform.rotation =  Quaternion.Slerp(brujulaGUI.transform.rotation, target,  Time.deltaTime * smooth);
            Debug.Log("Brújula: " + Input.compass.trueHeading.ToString() + generateDirection(Input.compass.trueHeading));
        }
        else {
            Input.location.Start();
        }      
    }

    /// <summary>
    /// Generates the directon of the Compass
    /// </summary>
    ///
    /// <param name="angle">The angle</param>
    ///
    /// <returns>< A string with the direction ></returns>
    private static string generateDirection(float angle) {
        switch ((int)(angle) % 8) {
            case 0:
                return "° North";
            case 1:
                return "° North-East";
            case 2:
                return "° East";
            case 3:
                return "° South-East";
            case 4:
                return "° South";
            case 5:
                return "° South-West";
            case 6:
                return "° West";
            case 7:
                return "° North-West";
            default:
                return "None";
        }
    }
}
