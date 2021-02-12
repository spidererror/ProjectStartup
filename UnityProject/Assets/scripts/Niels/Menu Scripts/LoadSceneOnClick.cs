using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnClick : ActionOnClick
{
    public int sceneIndex;

    protected override void onClick()
    {
        SceneManager.LoadScene(sceneIndex,LoadSceneMode.Single);
    }
}
