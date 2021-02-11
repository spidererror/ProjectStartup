using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitApplication : ActionOnClick
{
    protected override void onClick()
    {
        base.onClick();
        Application.Quit();
    }
}
