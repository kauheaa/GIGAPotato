using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WriteToFile : MonoBehaviour
{

    IEnumerator SendDataToFile()
    {
        bool successful = true;
        WWWForm form = new WWWForm();
        
        form.AddField("name", "kauheaa");
        form.AddField("age", "28");
        form.AddField("score", "125");
        WWW www = new WWW("http://localhost:3306/FromUnity.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Something went wrong.");
            successful = false;
        }
        else
        {
            Debug.Log(www.text);
            successful = true;
        }
    }

    IEnumerator GetDataFromFile()
    {
        bool successful = true;
        WWWForm form = new WWWForm();
        WWW www = new WWW("http://localhost:3306/ToUnity.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Something went wrong.");
            successful = false;
        }
        else
        {
            Debug.Log(www.text);
            successful = true;
        }
    }

    public void SendData()
    {
        StartCoroutine(SendDataToFile());
    }

    public void GetData()
    {
        StartCoroutine(GetDataFromFile());
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
