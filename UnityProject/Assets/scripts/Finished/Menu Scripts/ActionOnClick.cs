using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ActionOnClick : MonoBehaviour
{
    private Button _currentButton;

    protected virtual void Start()
    {
        _currentButton = GetComponent<Button>();
        _currentButton.onClick.AddListener(() => onClick());
    }

    protected virtual void onClick()
    {
        Debug.Log("BUTTON PRESSED WITH NAME: "+gameObject.name);
    }
}
