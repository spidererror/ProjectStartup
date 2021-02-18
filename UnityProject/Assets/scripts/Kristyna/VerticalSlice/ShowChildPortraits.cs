using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowChildPortraits : MonoBehaviour
{
    public GameObject canvas;
    public void ShowCanvas()
    {
        canvas.SetActive(true);
    }
    public void HideCanvas()
    {
        canvas.SetActive(false);
    }
}
