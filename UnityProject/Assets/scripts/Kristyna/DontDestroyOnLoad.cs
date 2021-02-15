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
        Debug.Log("isPhoneDone:::::" + isPhoneDone);

        //Debug.Log("Start isPhoneDone = " + isPhoneDone);
        DontDestroyOnLoad(this.transform);

        if (isPhoneDone)
        {
            Debug.Log("EXECUTUNG AFTER PHONE BLOCK");
            currentFlowchart.ExecuteBlock("AfterPhone");
        }
    }
    private void Start()
    {
        DontDestroyOnLoad(this.transform);
        Debug.Log("isPhoneDone:::::" + isPhoneDone);
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

    public void CheckIfPhoneDone()
    {
        if (isPhoneDone)
        {
            Debug.Log("EXECUTUNG AFTER PHONE BLOCK");
            currentFlowchart.ExecuteBlock("AfterPhone");
        }
        else
        {
            Debug.Log("Phone scene was not visited yet.");
        }
    }
}
