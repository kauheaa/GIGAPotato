using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class saveScore 
{
    public static void SaveScore(CalculateS calc)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/score.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

       scoreData data = new scoreData(calc);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Save score");
    }

    public static scoreData LoadScore()
    {
        string path = Application.persistentDataPath + "/score.txt";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            scoreData data = formatter.Deserialize(stream) as scoreData;
            stream.Close();
            Debug.Log("Load score");
            return data;


        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }

    }
}
