using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteSettingsManager : MonoBehaviour
{
    public int slowWritingSpeed = 40;
    public int medWritingSpeed = 60;
    public int fastWritingSpeed = 80;

    [HideInInspector]
    public int finalWritingSpeed;

    void Start()
    {   
        //listen to events from SettingsButtonScript
        SettingsButtonScript.FullscreenOn += fullscreenOn;
        SettingsButtonScript.FullscreenOff += fullscreenOff;

        SettingsButtonScript.SlowTextSpeed += textSpeedSlow;
        SettingsButtonScript.MedTextSpeed += textSpeedMed;
        SettingsButtonScript.FastTextSpeed += textSpeedFast;
    }

    //Fullscreen ---------------------------------------------------
    private void fullscreenOn()
    {
        Screen.fullScreen = true;
        Debug.Log("fullScreen = true");
    }
    private void fullscreenOff()
    {
        Screen.fullScreen = false;
        Debug.Log("fullScreen = false");
    }

    //Text speed ---------------------------------------------------
    private void textSpeedSlow()
    {
        finalWritingSpeed = slowWritingSpeed;
        Debug.Log("finalWritingSpeed = " + finalWritingSpeed);
    }
    private void textSpeedMed()
    {
        finalWritingSpeed = medWritingSpeed;
        Debug.Log("finalWritingSpeed = " + finalWritingSpeed);
    }
    private void textSpeedFast()
    {
        finalWritingSpeed = fastWritingSpeed;
        Debug.Log("finalWritingSpeed = " + finalWritingSpeed);
    }
}
