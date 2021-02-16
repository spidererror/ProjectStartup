using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonScript : MonoBehaviour
{
    /// <summary>
    /// Script for interaction with the menu and its sub-menus via buttons.
    /// </summary>

    [Header("Objects to hide")]
    //TextBox pane
    public bool areThereThingsToHide = true;
    public GameObject textBoxPanel;
    private bool _textboxPanelActive = true;
    [Space(10)]
    public GameObject[] ObjectsToHide;
    private bool _objectsHidden = false;

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
    // OBJECTS TO HIDE ---------------------------------
    public void HideAllObjects()
    {
        if (areThereThingsToHide)
        {
            if (!_objectsHidden)
            {
                foreach (GameObject element in ObjectsToHide)
                {
                    element.SetActive(false);
                }
                _objectsHidden = !_objectsHidden;
            }
        }
        
    }
    public void ShowAllObjects()
    {
        if (areThereThingsToHide)
        {
            if (_objectsHidden)
            {
                foreach (GameObject element in ObjectsToHide)
                {
                    element.SetActive(true);
                }
                _objectsHidden = !_objectsHidden;
            }
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
                _menuActive = true;//but it won't show again if you are in settings and click the menu button again

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
            _menuActive = false;//so the menu can show again
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
                _menuActive = true;//but it won't show again if you are in settings and click the menu button again

                Debug.Log("Save and Load open");
                SaveLoadObj.SetActive(true);
                _saveLoadActive = true;
            }
        }
    }
    public void CloseSaveLoad()
    {
        if (_saveLoadActive == true)
        {
            _menuActive = false;
            OpenMenu();//so buttons from menu cannot be clicked

            Debug.Log("Save and Load close");
            SaveLoadObj.SetActive(false);//turn of the save menu (blackboard)
            _saveLoadActive = false;//turn of all the objects belonging to the save menu
        }
    }

    // SAVE AND QUIT --------------------------------------------
    public void InitSaveQuit()
    {
        if (_menuActive == true)
        {             
            //Debug.Log("Save and Quit open");
            CloseMenu();//so buttons from menu cannot be clicked

            SceneManager.LoadScene("MenuExample");
        }
    }
}
