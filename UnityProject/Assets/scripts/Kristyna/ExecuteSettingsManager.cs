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

        SettingsButtonScript.SlowTextSpeed += textSpeedSlow;
        SettingsButtonScript.MedTextSpeed += textSpeedMed;
        SettingsButtonScript.FastTextSpeed += textSpeedFast;
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
