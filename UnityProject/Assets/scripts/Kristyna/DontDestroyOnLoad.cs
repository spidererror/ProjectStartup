using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class DontDestroyOnLoad : MonoBehaviour
{
    public Flowchart currentFlowchart;
    private bool isPhoneDone;
    void Awake()
    {
        Debug.Log("Start isPhoneDone = " + isPhoneDone);
        DontDestroyOnLoad(this.transform);

        if (isPhoneDone)
        {
            Debug.Log("EXECUTUNG AFTER PHONE BLOCK");
            currentFlowchart.ExecuteBlock("AfterPhone");
        }
    }

    public void setPhoneDoneTrue()
    {
        isPhoneDone = true;
        Debug.Log("NOW isPhoneDone = true");
    }
}
