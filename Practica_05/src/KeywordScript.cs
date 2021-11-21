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