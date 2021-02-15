using UnityEngine;
using UnityEngine.UI;
using System;

public class SettingsButtonScript : MonoBehaviour
{
    //Fullscreen mode:
    private bool _fullscreenModeActive;
    public Button FullscreenModeBTN;
    public Sprite CheckboxEmpty;
    public Sprite CheckboxFull;

    //Text speed buttons:
    private bool _slowActive = false;
    private bool _medActive = false;
    private bool _fastActive = false;
    [Space(10)]
    public Button SlowBTN; public Sprite SlowNotPressed; public Sprite SlowPressed;
    [Space(10)]
    public Button MedBTN;  public Sprite MedNotPressed;  public Sprite MedPressed;
    [Space(10)]
    public Button FastBTN; public Sprite FastNotPressed; public Sprite FastPressed;

    //Music slider:
    private int _musicVolume;
    [Space(10)]
    public Slider MusicSlider;

    //Sound slider:
    private int _soundVolume;
    public Slider SoundSlider;

    //Events for "ExecuteSettingsManager" to change the game's elements
    //text speed:
    public static event Action SlowTextSpeed;
    public static event Action MedTextSpeed;
    public static event Action FastTextSpeed;

    void Start()
    {
        //Default settings:
        _fullscreenModeActive = true;
        FullscreenClicked();

        _medActive = true;
        MedClicked();
    }

    //Fullscreen mode-------------------------------------------------------------------------
    public void FullscreenClicked()
    {
        if (_fullscreenModeActive == false)
        {
            FullscreenModeBTN.GetComponent<Image>().sprite = CheckboxFull;
            _fullscreenModeActive = true;
        }
        else if (_fullscreenModeActive == true)
        {
            FullscreenModeBTN.GetComponent<Image>().sprite = CheckboxEmpty;
            _fullscreenModeActive = false;
        }
    }

    //Text speed------------------------------------------------------------------------------
    public void SlowClicked()
    {
        if (_slowActive == false)
        {
            SlowBTN.GetComponent<Image>().sprite = SlowPressed;
            _slowActive = true;
            
            //Turn off the others:
            _medActive = false;  MedBTN.GetComponent<Image>().sprite = MedNotPressed;
            _fastActive = false; FastBTN.GetComponent<Image>().sprite = FastNotPressed;
        }
        else if (_slowActive == true)
        {
            SlowBTN.GetComponent<Image>().sprite = SlowNotPressed;
            _slowActive = false;
        }
    }
    public void MedClicked()
    {
        if (_medActive == false)
        {
            MedBTN.GetComponent<Image>().sprite = MedPressed;
            _medActive = true;

            //Turn off the others:
            _slowActive = false; SlowBTN.GetComponent<Image>().sprite = SlowNotPressed;
            _fastActive = false; FastBTN.GetComponent<Image>().sprite = FastNotPressed;
        }
        else if (_medActive == true)
        {
            MedBTN.GetComponent<Image>().sprite = MedNotPressed;
            _medActive = false;
        }
    }
    public void FastClicked()
    {
        if (_fastActive == false)
        {
            FastBTN.GetComponent<Image>().sprite = FastPressed;
            _fastActive = true;

            //Turn off the others:
            _slowActive = false; SlowBTN.GetComponent<Image>().sprite = SlowNotPressed;
            _medActive = false; MedBTN.GetComponent<Image>().sprite = MedNotPressed;
        }
        else if (_fastActive == true)
        {
            FastBTN.GetComponent<Image>().sprite = FastNotPressed;
            _fastActive = false;
        }
    }

    // Volume sliders ------------------------------------------------------------------------------
    public void MusicVolumeChange()
    {
        _musicVolume = (int)MusicSlider.value;
        Debug.Log(_musicVolume);
    }
    public void SoundVolumeChange()
    {
        _soundVolume = (int)SoundSlider.value;
        Debug.Log(_soundVolume);
    }

    // SAVE -----------------------------------------
    //Look through all the settings
    public void SavePressed()
    {
        //Text speed
        if (_slowActive == true)
        {
            SlowTextSpeed();
        }
        else if (_medActive == true)
        {
            MedTextSpeed();
        }
        else if (_fastActive == true)
        {
            FastTextSpeed();
        }
        //Volume
        
    }
}
