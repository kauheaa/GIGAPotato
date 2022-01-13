using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class saveScore
{
    public static void SaveBook(StickerBook book)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/booksave.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        scoreData data = new scoreData(book);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Book saved");
    }

    public static scoreData LoadBook()
    {
        string path = Application.persistentDataPath + "/booksave.txt";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);


            scoreData data = formatter.Deserialize(stream) as scoreData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

    //// Load starCounts and stickers in sticker book
    //public static scoreData LoadBook()
    //{

    //    string path = Application.persistentDataPath + "/booksave.txt";
    //    if (File.Exists(path))
    //    {
    //        BinaryFormatter formatter = new BinaryFormatter();
    //        FileStream stream = new FileStream(path, FileMode.Open);

    //        scoreData data = formatter.Deserialize(stream) as scoreData;
    //        stream.Close();
    //        return data;
    //    }
    //    else
    //    {
    //        Debug.LogError("Save file not found in " + path);
    //        return null;
    //    }
    //}






    //    //SUM SAVE
    //    public static void SaveSumScore(SumScript sum)
    //    {
    //        BinaryFormatter formatter = new BinaryFormatter();
    //        string path = Application.persistentDataPath + "/sumscore.txt";
    //        FileStream stream = new FileStream(path, FileMode.Create);

    //        scoreData data = new scoreData(sum);

    //        formatter.Serialize(stream, data);
    //        stream.Close();
    //        Debug.Log("Sum saved");
    //    }
    // SUM LOAD
    //public static scoreData LoadSumScore()
    //{

    //    string path = Application.persistentDataPath + "/sumscore.txt";
    //    if (File.Exists(path))
    //    {
    //        BinaryFormatter formatter = new BinaryFormatter();
    //        FileStream stream = new FileStream(path, FileMode.Open);

    //        scoreData data = formatter.Deserialize(stream) as scoreData;
    //        stream.Close();
    //        //Debug.Log("Load sum");
    //        return data;
    //    }
    //    else
    //    {
    //        Debug.LogError("Save file not found in" + path);
    //        return null;
    //    }
    //}

    //// SUB SAVE
    //    public static void SaveSubScore(SubScript sub)
    //    {
    //        BinaryFormatter formatter = new BinaryFormatter();
    //        string path = Application.persistentDataPath + "/subscore.txt";
    //        FileStream stream = new FileStream(path, FileMode.Create);

    //        scoreData data = new scoreData(sub);

    //        formatter.Serialize(stream, data);
    //        stream.Close();
    //        Debug.Log("Sub saved");
    //    }
    //// SUB LOAD
    //    public static scoreData LoadSubScore()
    //    {
    //        string path = Application.persistentDataPath + "/subscore.txt";
    //        if (File.Exists(path))
    //        {
    //            BinaryFormatter formatter = new BinaryFormatter();
    //            FileStream stream = new FileStream(path, FileMode.Open);

    //            scoreData data = formatter.Deserialize(stream) as scoreData;
    //            stream.Close();
    //            //Debug.Log("Load sub");
    //            return data;
    //        }
    //        else
    //        {
    //            Debug.LogError("Save file not found in" + path);
    //            return null;
    //        }
    //    }


    //    // COUNT SAVE
    //    public static void SaveCountScore(CountScript count)
    //    {
    //        BinaryFormatter formatter = new BinaryFormatter();
    //        string path = Application.persistentDataPath + "/countscore.txt";
    //        FileStream stream = new FileStream(path, FileMode.Create);

    //        scoreData data = new scoreData(count);

    //        formatter.Serialize(stream, data);
    //        stream.Close();
    //        Debug.Log("Count saved");
    //    }
    //    // MULTIPLY LOAD
    //    public static scoreData LoadCountScore()
    //    {
    //        string path = Application.persistentDataPath + "/countscore.txt";
    //        if (File.Exists(path))
    //        {
    //            BinaryFormatter formatter = new BinaryFormatter();
    //            FileStream stream = new FileStream(path, FileMode.Open);

    //            scoreData data = formatter.Deserialize(stream) as scoreData;
    //            stream.Close();
    //            //Debug.Log("Load count");
    //            return data;
    //        }
    //        else
    //        {
    //            Debug.LogError("Save file not found in" + path);
    //            return null;
    //        }
    //    }
    //    public static void SaveMultScore(MultiplyScript mult)
    //    {
    //        BinaryFormatter formatter = new BinaryFormatter();
    //        string path = Application.persistentDataPath + "/multscore.txt";
    //        FileStream stream = new FileStream(path, FileMode.Create);

    //        scoreData data = new scoreData(mult);

    //        formatter.Serialize(stream, data);
    //        stream.Close();
    //        Debug.Log("Mult saved");
    //    }
    //    // MULTIPLY LOAD
    //    public static scoreData LoadMultScore()
    //    {
    //        string path = Application.persistentDataPath + "/multscore.txt";
    //        if (File.Exists(path))
    //        {
    //            BinaryFormatter formatter = new BinaryFormatter();
    //            FileStream stream = new FileStream(path, FileMode.Open);

    //            scoreData data = formatter.Deserialize(stream) as scoreData;
    //            stream.Close();
    //            //Debug.Log("Load mult");
    //            return data;
    //        }
    //        else
    //        {
    //            Debug.LogError("Save file not found in" + path);
    //            return null;
    //        }
    //    }

    //    //DIVIDE SAVE
    //    public static void SaveDivScore(DivideScript div)
    //    {
    //        BinaryFormatter formatter = new BinaryFormatter();
    //        string path = Application.persistentDataPath + "/divscore.txt";
    //        FileStream stream = new FileStream(path, FileMode.Create);

    //        scoreData data = new scoreData(div);

    //        formatter.Serialize(stream, data);
    //        stream.Close();
    //        Debug.Log("Div saved");
    //    }

    //    // DIVIDE LOAD
    //    public static scoreData LoadDivScore()
    //    {
    //        string path = Application.persistentDataPath + "/divscore.txt";
    //        if (File.Exists(path))
    //        {
    //            BinaryFormatter formatter = new BinaryFormatter();
    //            FileStream stream = new FileStream(path, FileMode.Open);

    //            scoreData data = formatter.Deserialize(stream) as scoreData;
    //            stream.Close();
    //            //Debug.Log("Load div");
    //            return data;
    //        }
    //        else
    //        {
    //            Debug.LogError("Save file not found in" + path);
    //            return null;
    //        }
    //    }
}
