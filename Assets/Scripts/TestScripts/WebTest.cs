using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebTest : MonoBehaviour
{
    IEnumerator Start()
    {
        WWW request = new WWW("http://kauheaa.com/gigapotato/sqlconnect/webtest.php");
        yield return request;
        string[] webResults = request.text.Split('\t'); // splits the text by character (single quote for character, double for string)
        Debug.Log(webResults[0]); // makes the results an array and posts first item as string
        int webNumber = int.Parse(webResults[1]); // turns second string item on array into int
        webNumber *= 2; // doubles webNumber
        Debug.Log(webNumber);
    }
}
