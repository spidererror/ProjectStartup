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
    private Slider _slider;
    private float _startValue = 20;
    private void Start()
    {
        _slider = GetComponent<Slider>();
    }

    public void OnSliderChange(string volumeName)
    {
        mixer.audioMixer.SetFloat(volumeName, _startValue*_slider.value);
    }
}
