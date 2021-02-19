using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChangeWritingSpeedOnClick : ActionOnClick
{
    [SerializeField]
    private float _currentSpeed;
    private SettingData _settings;

    protected override void Start()
    {
        base.Start();
        _settings = GameObject.FindGameObjectsWithTag("Settings").First().GetComponent<SettingData>();
    }

    protected override void onClick()
    {
        base.onClick();
        _settings.writingSpeed = _currentSpeed;
    }
}
