using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SceneData
{
    public int currentChapter;
    public int dialogueID;
    public int[] currentCurseScore = new int[4];
    public string currentDate;
    public string sceneName;
    public SceneData(ActiveScene activeScene)
    {
        currentChapter = activeScene.currentChapter;
        dialogueID = activeScene.dialogueID;
        currentCurseScore = activeScene.currentCurseScore;
        currentDate = activeScene.currentDate;
        sceneName = activeScene.sceneName;
    }
}
