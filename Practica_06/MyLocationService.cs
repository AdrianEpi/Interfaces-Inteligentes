using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class describes my location service.
/// </summary>
public class MyLocationService : MonoBehaviour {

    // <summary>
    // Start is called before the first frame update
    // </summary>
    //
    // <returns>I enumerator.</returns>
    IEnumerator Start() {
        yield return new WaitForSeconds(4);
        // Check if the user has location service enabled.
        if (!Input.location.isEnabledByUser) {
            Debug.Log("GPS Desconectado");
            yield break;
        }
        // Starts the location service.
        Input.location.Start();

        // Waits until the location service initializes
        int maxWait = 10;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0) {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        // If the service didn't initialize in 20 seconds this cancels location service use.
        if (maxWait < 1) {
            print("Timed out");
            yield break;
        }

        // If the connection failed this cancels location service use.
        if (Input.location.status == LocationServiceStatus.Failed) {
            print("Unable to determine device location");
            yield break;
        }
        else {
            Debug.Log("GPS:\n\t- Latitud:" + Input.location.lastData.latitude + "\n\t- Longitud:" + Input.location.lastData.longitude + "\n\t- Altitud:" + Input.location.lastData.altitude);
        }
        Input.location.Stop();
        Debug.Log("Stopped");
    }

    /// <summary>
    /// Updates the object.
    /// </summary>
    void Update () {
        if (Input.location.status ==LocationServiceStatus.Running)
            Debug.Log("GPS:\n\t- Latitud:" + Input.location.lastData.latitude + "\n\t- Longitud:" + Input.location.lastData.longitude + "\n\t- Altitud:" + Input.location.lastData.altitude);
        else {
            Debug.Log("GPS Offline");
            Input.location.Start();
        }
    }
}