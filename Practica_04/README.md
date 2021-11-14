# Práctica: Micrófono y cámara

---

Adrián Epifanio Rodríguez Hernández

---

### Ejecución con uso de cámara y micrófono

<div align="center">
  <br>
  <img src="img/1.gif" alt="Markdownify">
  <br>
  <br>
</div>

---

### Cámara

Para la realización de esta práctica he puesto la salida de la cámara en un cubo en la cabeza de un personaje para que se vea lo que capta la cámara en lugar de la cabeza original. Por ello la cámara se enciente al arrancar la ejecución y se mantiene hasta la finalización de la ejecución.
```cs
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
```

---

### Micrófono

Para la realización de esta práctica he puesto un micrófono que graba y transmite durante 50 segundos desde el inicio de la ejecución. La salida del audio está vinculada al personaje de forma que siempre se pueda oir como si fuese el quien estubiese hablando. Además de ha implementado una función en el micrófono de forma que cuando este pulsa la tecla Z este realiza un grito.

```cs
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
```
