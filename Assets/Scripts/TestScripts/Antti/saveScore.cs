using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class saveScore 
{

// SUM SAVE
    public static void SaveSumScore(SumScript sum)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/sumscore.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        scoreData data = new scoreData(sum);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Save addition stickers");
    }
// SUM LOAD
    public static scoreData LoadSumScore()
    {
        string path = Application.persistentDataPath + "/sumscore.txt";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            scoreData data = formatter.Deserialize(stream) as scoreData;
            stream.Close();
            Debug.Log("Load sum sticker scores");
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }

    }



// SUB SAVE
    public static void SaveSubScore(SubScript sub)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/subscore.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        scoreData data = new scoreData(sub);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Save sub stickers");
    }
// SUB LOAD
    public static scoreData LoadSubScore()
    {
        string path = Application.persistentDataPath + "/subscore.txt";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            scoreData data = formatter.Deserialize(stream) as scoreData;
            stream.Close();
            Debug.Log("Load sub sticker scores");
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }

    }


    // COUNT SAVE
    public static void SaveCountScore(CountScript count)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/countscore.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        scoreData data = new scoreData(count);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Save count stickers");
    }
    // MULTIPLY LOAD
    public static scoreData LoadCountScore()
    {
        string path = Application.persistentDataPath + "/countscore.txt";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            scoreData data = formatter.Deserialize(stream) as scoreData;
            stream.Close();
            Debug.Log("Load count sticker scores");
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }

    }
    public static void SaveMultScore(MultiplyScript mult)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/multscore.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        scoreData data = new scoreData(mult);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Save count stickers");
    }
    // MULTIPLY LOAD
    public static scoreData LoadMultScore()
    {
        string path = Application.persistentDataPath + "/multscore.txt";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            scoreData data = formatter.Deserialize(stream) as scoreData;
            stream.Close();
            Debug.Log("Load count sticker scores");
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }

    }

    //DIVIDE SAVE
    public static void SaveDivScore(DivideScript div)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/divscore.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        scoreData data = new scoreData(div);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Save count stickers");
    }

    // DIVIDE LOAD
    public static scoreData LoadDivScore()
    {
        string path = Application.persistentDataPath + "/divscore.txt";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            scoreData data = formatter.Deserialize(stream) as scoreData;
            stream.Close();
            Debug.Log("Load count sticker scores");
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }

    }


    //RESET ALL SCORES
    public static void ResetAllScore(SumScript sum, SubScript sub)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/sumscore.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        scoreData data = new scoreData(sum);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Reset all sticker scores");
    }
}
