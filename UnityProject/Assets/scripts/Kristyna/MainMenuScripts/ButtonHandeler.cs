using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandeler : MonoBehaviour
{
    public void ExitApplication()
    {
        this.ExitApplication();
    }
    public void GoToPrototype()
    {
        SceneManager.LoadScene("TestSimulation#1294");
    }
    public void GoToOptions()
    {
        Debug.Log("Nothing here yet!");
    }
}
