using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using UnityEngine.XR.WSA.Input;

public class SpeechData : MonoBehaviour
{
    GestureRecognizer gr;
    public Text _statusText;
    public Text _subtitleText;
    DictationRecognizer dr;

    private void Start()
    {
        gr = new GestureRecognizer();
        gr.StartCapturingGestures();
    }
    private void Awake()
    {
        dr = new DictationRecognizer();
        dr.DictationHypothesis += dr_DictationHypothesis;
        dr.DictationResult += dr_DictationResult;
    }

    private void dr_DictationComplete(DictationCompletionCause cause)
    {
        dr.Stop();
        SetSleeping();

    }

    private void dr_DictationResult(string text, ConfidenceLevel confidence)
    {
        this._subtitleText.text = text;
        SetListening();
    }

    private void dr_DictationHypothesis(string text)
    {
        SetThinking();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            
        }
    }

    private void SetListening()
    {
        this._statusText.text = "-Listening-";
    }

    private void SetSleeping()
    {
        this._statusText.text = "-Sleeping-";
        this._subtitleText.text = string.Empty;
    }

    private void SetThinking()
    {
        this._statusText.text = "Thinking...";
    }

    public void SpeechStart(){
        SetListening();
        dr.Start();
    }

    public void SpeechStop(){
        SetSleeping();
        dr.Stop();
    }
}