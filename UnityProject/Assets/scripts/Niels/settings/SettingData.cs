using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using System.Linq;

public class SettingData:MonoBehaviour
{
    public float writingSpeed = 80;
    private Writer _currentWriter;

    private bool _isFullscreenOn = false;

    private void Start()
    {
        _currentWriter = GameObject.FindGameObjectsWithTag("SayDialogue").First().GetComponent<Writer>();
    }

    private void Update()
    {
        //update writingSpeed;
        _currentWriter.writingSpeed = writingSpeed;
    }

    //Writing speed buttons--------------------------

    //Fullscreen ---------------------------------------------------
    public void fullscreenOnOff()
    {
        if (_isFullscreenOn)
        {
            Screen.fullScreen = false;
            Debug.Log("fullScreen = false");
        }
        else
        {
            Screen.fullScreen = true;
            Debug.Log("fullScreen = true");
        }
    }
}

