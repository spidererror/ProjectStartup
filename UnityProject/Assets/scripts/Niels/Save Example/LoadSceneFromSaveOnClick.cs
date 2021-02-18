using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneFromSaveOnClick : ActionOnClick
{
    public ActiveScene currentScene;

    protected override void onClick()
    {
        base.onClick();
        SceneManager.LoadScene(currentScene.sceneName,LoadSceneMode.Single);
    }
}
