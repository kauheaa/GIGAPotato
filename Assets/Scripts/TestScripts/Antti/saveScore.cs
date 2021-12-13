using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class saveScore 
{
    public static void SaveSumScore(SumScript sum)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/sumscore.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

       scoreData data = new scoreData(sum);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Save sumscore");
    }
  
    public static scoreData LoadSumScore()
    {
        string path = Application.persistentDataPath + "/sumscore.txt";
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
