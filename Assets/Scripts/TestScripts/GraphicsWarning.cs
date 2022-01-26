using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class GraphicsWarning : MonoBehaviour
{
    [SerializeField] private Transform graphicsWarning;
    public bool resolutionCheck = false;

    // Start is called before the first frame update
    //public void SaveResoCheck()
    //{
    //    saveScore.SaveResoCheck(this);
    //}
    //public void LoadResoCheck()
    //{
    //    string path = Application.persistentDataPath + "/resocheck.txt";
    //    if (File.Exists(path))
    //    {
    //        scoreData data = saveScore.LoadResoCheck();
    //        resolutionCheck = data.resolutionCheck;
    //        Debug.Log("Reso check ok");
    //    }
    //    else
    //    {
    //        SaveResoCheck();
    //    }
    //}

    //private void Start()
    //{
    //    LoadResoCheck();
    //    if (resolutionCheck == true)
    //    {
    //        graphicsWarning.gameObject.SetActive(false);
    //    }
    //}

    //public void CloseGraphicsWarning()
    //{
    //    graphicsWarning.gameObject.SetActive(false);
    //    resolutionCheck = true;
    //    SaveResoCheck();
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
