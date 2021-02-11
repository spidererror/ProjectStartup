using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwitchScreen : ActionOnClick
{
    public GameObject turnOffScreen;
    public GameObject turnOnScreen;

    protected override void onClick()
    {
        turnOffScreen.SetActive(false);
        turnOnScreen.SetActive(true);
    }

}
