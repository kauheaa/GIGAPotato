using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WriteToFile : MonoBehaviour
{
    public StickerBook book;
    public string stickerScores;
    
    IEnumerator SendDataToFile()
    {
        bool successful = true;
        WWWForm form = new WWWForm();
        form.AddField("Field", book.appleStickerScore);
        form.AddField("Field", book.sumFarmStarCount);
        form.AddField("Field", book.sumJungleStarCount);
        form.AddField("Field", book.sumSpaceStarCount);
        form.AddField("Field", book.subFarmStarCount);
        form.AddField("Field", book.subJungleStarCount);
        form.AddField("Field", book.subSpaceStarCount);
        form.AddField("Field", book.countFarmStarCount);
        form.AddField("Field", book.countJungleStarCount);
        form.AddField("Field", book.countSpaceStarCount);
        form.AddField("Field", book.multJungleStarCount);
        form.AddField("Field", book.multSpaceStarCount);
        form.AddField("Field", book.divJungleStarCount);
        form.AddField("Field", book.divSpaceStarCount);

        form.AddField("Field", book.appleStickerScore);
        form.AddField("Field", book.basketStickerScore);
        form.AddField("Field", book.pigStickerScore);
        form.AddField("Field", book.carrotStickerScore);
        form.AddField("Field", book.bucketStickerScore);
        form.AddField("Field", book.bunnyStickerScore);
        form.AddField("Field", book.threeCornStickerScore);
        form.AddField("Field", book.twoCornStickerScore);
        form.AddField("Field", book.lambStickerScore);

        form.AddField("Field", book.bananaStickerScore);
        form.AddField("Field", book.clusterStickerScore);
        form.AddField("Field", book.monkeyStickerScore);
        form.AddField("Field", book.coconutStickerScore);
        form.AddField("Field", book.ocularsStickerScore);
        form.AddField("Field", book.slothStickerScore);
        form.AddField("Field", book.lycheeStickerScore);
        form.AddField("Field", book.pitahayaStickerScore);
        form.AddField("Field", book.frogStickerScore);
        form.AddField("Field", book.avocadoStickerScore);
        form.AddField("Field", book.toolStickerScore);
        form.AddField("Field", book.tigerStickerScore);

        form.AddField("Field", book.asteroidStickerScore);
        form.AddField("Field", book.blackholeStickerScore);
        form.AddField("Field", book.llamaStickerScore);
        form.AddField("Field", book.starStickerScore);
        form.AddField("Field", book.planetStickerScore);
        form.AddField("Field", book.cowStickerScore);
        form.AddField("Field", book.flagStickerScore);
        form.AddField("Field", book.rocketStickerScore);
        form.AddField("Field", book.laikaStickerScore);
        form.AddField("Field", book.driedfishStickerScore);
        form.AddField("Field", book.octopusStickerScore);
        form.AddField("Field", book.catStickerScore);

        WWW www = new WWW("http://kauheaa.com/gigapotato/FromUnity.php", form);

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
        WWW www = new WWW("http://kauheaa.com/gigapotato/FromUnity.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Something went wrong.");
            successful = false;
        }
        else
        {
            Debug.Log(www.text);
            stickerScores = www.text;

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
