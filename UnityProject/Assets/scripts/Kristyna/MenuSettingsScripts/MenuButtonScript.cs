using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonScript : MonoBehaviour
{
    /// <summary>
    /// Script for interaction with the menu and its sub-menus via buttons.
    /// </summary>

    //TextBox pane
    public GameObject textBoxPanel;
    private bool _textboxPanelActive = true;

    //Menu in general:
    public GameObject MenuObj;
    private bool _menuActive = false;

    //Menu sub-menus:
    public GameObject SettingsObj;
    private bool _settingsActive = false;

    public GameObject SaveLoadObj;
    private bool _saveLoadActive = false;

    //save and quit -> switch scene


    void Start()
    {
        MenuObj.SetActive(false);
        SettingsObj.SetActive(false);
        SaveLoadObj.SetActive(false);
        textBoxPanel.SetActive(true);
    }

    //TextBox Panel ---------------------------------------
    public void TextboxPanelHideShow()
    {
        if (_textboxPanelActive == false)
        {
            textBoxPanel.SetActive(true);
            _textboxPanelActive = true;
        }
        else
        {
            textBoxPanel.SetActive(false);
            _textboxPanelActive = false;
        }
    }
    // MENU --------------------------------------------
    public void OpenMenu()
    {
        if (_menuActive == false)
        {
            Debug.Log("Menu open");
            MenuObj.SetActive(true);
            _menuActive = true;
        }
    }
    public void CloseMenu()
    {
        if (_menuActive == true)
        {
            Debug.Log("Menu close");
            MenuObj.SetActive(false);
            _menuActive = false;
        }
    }
    // SETTINGS --------------------------------------------
    public void OpenSettings()
    {
        if (_menuActive == true)
        {
            if (_settingsActive == false)
            {
                CloseMenu();//so buttons from menu cannot be clicked

                Debug.Log("Settings open");
                SettingsObj.SetActive(true);
                _settingsActive = true;
            }
        }
    }
    public void CloseSettings()
    {
        if (_settingsActive == true)
        {
            OpenMenu();//make menu accessible/usable again

            Debug.Log("Settings close");
            SettingsObj.SetActive(false);
            _settingsActive = false;
        }
    }
    // SAVE AND LOAD --------------------------------------------
    public void OpenSaveLoad()
    {
        if (_menuActive == true)
        {
            if (_saveLoadActive == false)
            {
                CloseMenu();//so buttons from menu cannot be clicked

                Debug.Log("Save and Load open");
                SaveLoadObj.SetActive(true);
                _saveLoadActive = true;
            }
        }
    }
    public void CloseSaveLoad()
    {
        if (_menuActive == false)
        {
            if (_saveLoadActive == true)
            {
                OpenMenu();//so buttons from menu cannot be clicked

                Debug.Log("Save and Load close");
                SaveLoadObj.SetActive(false);
                _saveLoadActive = false;
            }
        }
    }

    // SAVE AND QUIT --------------------------------------------
    public void InitSaveQuit()
    {
        if (_menuActive == true)
        {             
            Debug.Log("Save and Quit open");
            CloseMenu();//so buttons from menu cannot be clicked
            //CHANGE THE SCENE
        }
    }
}
