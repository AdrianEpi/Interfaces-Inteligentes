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

### KeywordRecognizer

Para la utilización del reconocimiento de palabras por voz hemos implementado la clase KeywordScript que se activa cuando se pulsa la tecla "P", mientras está activo reconoce la palabra "FUSRODA", se ha escogido esta palabra en referencia a un juego llamado Skyrim en el que el personaje grita "Fus Ro Dah" y acto seguido empuja lo que tiene delante. En el caso de esta práctica cuando la persona dice la palabra empuja una esfera hacia delante y debe intentar tirar los cilindros a modo de bolos.

```cs
using System;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.Speech;

/// <summary>
/// This class describes a keyword script.
/// </summary>
public class KeywordScript : MonoBehaviour {
    [SerializeField]
    private string[] m_Keywords;
    public Empujar fusRoDah_;
    private bool finished_;
    private KeywordRecognizer m_Recognizer;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start () {
        Debug.Log("Pulse la tecla P para comenzar el KeywordRecognizer.");
        m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
        if (Input.GetKey(KeyCode.P) && !m_Recognizer.IsRunning) {
            StartKeywordRecognizer();
            Debug.Log("Pulse la tecla P para parar el KeywordRecognizer.");
        }
        else if (Input.GetKey(KeyCode.P)) {
            Finish();
        }
    }

    /// <summary>
    /// Starts a keyword recognizer.
    /// </summary>
    void StartKeywordRecognizer() {
        
        m_Recognizer.Start();
        finished_ = false;
    }

    /// <summary>
    /// Finishes the KeywordRecognizer and releases the resources
    /// </summary>
    public void Finish () {
        if (get_Finished()) {
            m_Recognizer.Stop();
            m_Recognizer.Dispose();
            Debug.Log("Stopped KeywordRecognizer");
        }
    }

    /// <summary>
    /// Called when phrase recognized.
    /// </summary>
    ///
    /// <param name="args">The arguments</param>
    private void OnPhraseRecognized(PhraseRecognizedEventArgs args) {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
        builder.AppendFormat("\tTimestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tDuration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());
        fusRoDah_.FusRoDah();   
        finished_  = true;
    }

    /// <summary>
    /// Gets the finished.
    /// </summary>
    ///
    /// <returns>The finished.</returns>
    public bool get_Finished() {
        return finished_;
    }

    /// <summary>
    /// Sets the finished.
    /// </summary>
    ///
    /// <param name="newFinished">Indicates if new finished</param>
    public void set_Finished(bool newFinished) {
        finished_ = newFinished;
    }
}
```

---

### DictationRecognizer

Para esta práctica debido a que no pueden estar activos a la vez el KeywordRecognizer y el DictationRecognizer he decicido crear la clase DictationScript, esta clase se activa al pulsar la tecla "O", desde ese momento la clase se encarga de transcribir todo lo que el usuario dice por voz. Para finalizar el dictado por voz se debe volver a presionar la tecla "O".

```cs
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

/// <summary>
/// This class describes a dictation script.
/// </summary>
public class DictationScript : MonoBehaviour {
    [SerializeField]
    private Text m_Hypotheses;
    [SerializeField]
    private Text m_Recognitions;
    private DictationRecognizer m_DictationRecognizer;
    private bool isRunning;


    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start () {
         Debug.Log("Pulse la tecla O para comenzar el dictado por voz.");
         isRunning = false;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
        if (Input.GetKey(KeyCode.O) && !isRunning) {
            StartDictation();
            Debug.Log("Pulse la tecla O para parar el dictado por voz.");
            isRunning = true;
        }
        else if (Input.GetKey(KeyCode.O)) {
            Finish();
        }
    }

    /// <summary>
    /// Finishes the DictationScript and releases the resources
    /// </summary>
    void Finish () {
        m_DictationRecognizer.Stop();
        m_DictationRecognizer.Dispose();
        Debug.Log("Stopped dictado por voz.");
    }

    /// <summary>
    /// Starts a dictation.
    /// </summary>
    void StartDictation() {
        m_DictationRecognizer = new DictationRecognizer();
        m_DictationRecognizer.DictationResult += (text, confidence) => {
            Debug.LogFormat("Dictation result: {0}", text);
            //m_Recognitions.text += text + "\n";
        };
        m_DictationRecognizer.DictationHypothesis += (text) => {
            Debug.LogFormat("Dictation hypothesis: {0}", text);
            //m_Hypotheses.text += text;
        };
        m_DictationRecognizer.DictationComplete += (completionCause) => {
            if (completionCause != DictationCompletionCause.Complete)
                Debug.LogErrorFormat("Dictation completed unsuccessfully: {0}.", completionCause);
        };
        m_DictationRecognizer.DictationError += (error, hresult) => {
            Debug.LogErrorFormat("Dictation error: {0}; HResult = {1}.", error, hresult);
        };
        m_DictationRecognizer.Start();    
    }
}
```