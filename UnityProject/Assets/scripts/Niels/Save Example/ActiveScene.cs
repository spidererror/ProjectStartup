using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActiveScene : MonoBehaviour
{
    
    public int currentChapter;
    public int dialogueID;
    public int[] currentCurseScore;
    public string currentDate;
    public string sceneName;

    private void Update()
    {
        setDate();
    }

    //----Systems for saving and loading data---//
    public void SaveScene(int saveSlot)
    {
        SaveSystem.SaveScene(this,saveSlot);
    }

    public void LoadScene(int saveSlot)
    {
        SceneData data = SaveSystem.LoadScene(saveSlot);
        currentChapter = data.currentChapter;
        dialogueID = data.dialogueID;
        currentCurseScore = data.currentCurseScore;
        sceneName = data.sceneName;

    }

    //-----Settin active scene data------//
    private void setDate()
    {
        string time = ""+System.DateTime.Now.TimeOfDay;
        time = time.Split('.')[0];

        currentDate = ""+System.DateTime.UtcNow.Month+"/" + System.DateTime.UtcNow.Day+"/"+System.DateTime.UtcNow.Year+"\n"
            +time;
    }

    public void setDialogueID(int id)
    {
        dialogueID = id;
    }

    public void setCurrentChapter(int chapter)
    {
        currentChapter = chapter;
    }

    public void setCurseScore(int[] currentCurseScores)
    {
        currentCurseScore = currentCurseScores;
    }

    /*public void SetCurrenSaveSlot(int saveSlot)
    {
        _currentSaveSlot = saveSlot;
    }

    public string GetText()
    {
        string saveSlot = "save" + _currentSaveSlot + "\n";
        string chapter = "chapter" + currentChapter + "\n";
        string date = "save" + currentDate + "\n";
        return saveSlot + chapter + date;
    }*/
}
