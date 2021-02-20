using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrlOnClick : ActionOnClick
{
    public string url;

    protected override void onClick()
    {
        base.onClick();
        Application.OpenURL(url);
    }

}
