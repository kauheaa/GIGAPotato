using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class save2score
{
    public static void SaveSubScore(SubScript sub)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/subscore.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        score2data data = new score2data(sub);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Save sub Score");
    }

    public static score2data LoadSubScore()
    {
        string path = Application.persistentDataPath + "/subscore.txt";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            score2data data = formatter.Deserialize(stream) as score2data;
            stream.Close();
            Debug.Log("Load Sub Score");
            return data;


        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }

    }

}
