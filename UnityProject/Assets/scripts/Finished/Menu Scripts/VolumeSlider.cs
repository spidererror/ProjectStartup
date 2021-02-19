using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Linq;

public class VolumeSlider : MonoBehaviour
{
    public AudioMixerGroup mixer;
    public string volumeName = "VolumeMusic";
    private Slider _slider;
    private float _startValue = 20;
    private float _mixerValue;
    private void Start()
    {
        _slider = GetComponent<Slider>();
        mixer.audioMixer.GetFloat(volumeName, out _mixerValue);
        _slider.value = _mixerValue;
    }

    public void OnSliderChange(string volumeName)
    {
        mixer.audioMixer.SetFloat(volumeName, _slider.value);
    }
}
