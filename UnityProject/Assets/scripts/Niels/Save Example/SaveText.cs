using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveText : MonoBehaviour
{
    public List<Text> currentText;

    public void LoadSceneDataToText()
    {
        for (int saveSlot = 1; saveSlot < currentText.Count+1; saveSlot++)
        {
            if (SaveSystem.LoadScene(saveSlot) != null)
            {
                SceneData data = SaveSystem.LoadScene(saveSlot);

               // string currentSaveSlot = "save" + saveSlot + "\n";
                string chapter = "chapter" + data.currentChapter + "\n" + data.sceneName+"\n";
                string date = "" + data.currentDate + "\n";
                setText(saveSlot-1,chapter + date);
            }
            else
            {
                currentText[saveSlot-1].text = "save"+saveSlot+"\n EMPTY";
            }
        }
        
    }

    private void setText(int saveSlot, string currentSaveText)
    {
        currentText[saveSlot].text = currentSaveText;
    }
}
