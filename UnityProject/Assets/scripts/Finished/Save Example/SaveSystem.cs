using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class SaveSystem
{
    private static string _saveFileName = "/save";
    public static void SaveScene(ActiveScene activeScene, int saveSlot)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + _saveFileName+saveSlot;

        FileStream stream = new FileStream(path, FileMode.Create);

        SceneData data = new SceneData(activeScene);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("saved scene at: "+path);
    }

    public static void DeleteSaveAt(int saveSlot)
    {
        string path = Application.persistentDataPath + _saveFileName + saveSlot;
        File.Delete(path);
    }

    public static SceneData LoadScene(int saveSlot)
    {
        string path = Application.persistentDataPath + _saveFileName+saveSlot;
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SceneData data = formatter.Deserialize(stream) as SceneData;
            stream.Close();
            Debug.Log("load scene at: " + path);
            return data;
        }
        else
        {
            Debug.Log("No Save To Load at: " + saveSlot);
            return null;
        }
    }
}
