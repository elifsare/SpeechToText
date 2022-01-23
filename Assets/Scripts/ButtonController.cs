using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonController : MonoBehaviour
{
    public SpeechData sd;
    public RobiAnimationController rac;
    public GameObject[] buttons;
    public void OpenBTN(){
        sd.SpeechStart();
        rac.OpenAnim();
        buttons[0].SetActive(false);
        buttons[1].SetActive(true);
    }
    public void CloseBTN(){
        sd.SpeechStop();
        rac.CloseAnim();
        buttons[1].SetActive(false);
        buttons[0].SetActive(true);
    }
}
