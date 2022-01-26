using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WriteToFile : MonoBehaviour
{
    public StickerBook book;
    public string stickerScores;

    IEnumerator SavePlayerData()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", DatabaseManager.username);
        form.AddField("sumfarm", book.sumFarmStarCount);
        form.AddField("sumjungle", book.sumJungleStarCount);
        form.AddField("sumspace", book.sumSpaceStarCount);
        form.AddField("substar", book.subFarmStarCount);
        form.AddField("subjungle", book.subJungleStarCount);
        form.AddField("subspace", book.subSpaceStarCount);
        form.AddField("countfarm", book.countFarmStarCount);
        form.AddField("countjungle", book.countJungleStarCount);
        form.AddField("countspace", book.countSpaceStarCount);
        form.AddField("multjungle", book.multJungleStarCount);
        form.AddField("multspace", book.multSpaceStarCount);
        form.AddField("divjungle", book.divJungleStarCount);
        form.AddField("divspace", book.divSpaceStarCount);

        form.AddField("apple", book.appleStickerScore);
        form.AddField("basket", book.basketStickerScore);
        form.AddField("pig", book.pigStickerScore);
        form.AddField("carrot", book.carrotStickerScore);
        form.AddField("bucket", book.bucketStickerScore);
        form.AddField("bunny", book.bunnyStickerScore);
        form.AddField("twocorn", book.threeCornStickerScore);
        form.AddField("threecorn", book.twoCornStickerScore);
        form.AddField("unicorn", book.lambStickerScore);

        form.AddField("banana", book.bananaStickerScore);
        form.AddField("cluster", book.clusterStickerScore);
        form.AddField("monkey", book.monkeyStickerScore);
        form.AddField("coconut", book.coconutStickerScore);
        form.AddField("oculars", book.ocularsStickerScore);
        form.AddField("sloth", book.slothStickerScore);
        form.AddField("lychee", book.lycheeStickerScore);
        form.AddField("pitahaya", book.pitahayaStickerScore);
        form.AddField("frog", book.frogStickerScore);
        form.AddField("avocado", book.avocadoStickerScore);
        form.AddField("tool", book.toolStickerScore);
        form.AddField("tiger", book.tigerStickerScore);

        form.AddField("asteroid", book.asteroidStickerScore);
        form.AddField("blackhole", book.blackholeStickerScore);
        form.AddField("llama", book.llamaStickerScore);
        form.AddField("star", book.starStickerScore);
        form.AddField("planet", book.planetStickerScore);
        form.AddField("cow", book.cowStickerScore);
        form.AddField("flag", book.flagStickerScore);
        form.AddField("rocket", book.rocketStickerScore);
        form.AddField("laika", book.laikaStickerScore);
        form.AddField("driedfish", book.driedfishStickerScore);
        form.AddField("octopus", book.octopusStickerScore);
        form.AddField("cat", book.catStickerScore);

        WWW www = new WWW("http://kauheaa.com/gigapotato/sqlconnect/savedata.php", form);

        yield return www;
        if (www.text[0] == '0')
        {
            Debug.Log("Score saved:" + www.text);
        }
        else
        {
            Debug.Log("Save failed. Error #" + www.text);
        }
    }

    public void CallSaveData()
    {
        StartCoroutine(SavePlayerData());
    }

    //IEnumerator GetDataFromFile()
    //{
    //    bool successful = true;
    //    WWWForm form = new WWWForm();
    //    WWW www = new WWW("http://kauheaa.com/gigapotato/FromUnity.php", form);

    //    yield return www;
    //    if (www.error != null)
    //    {
    //        Debug.Log("Something went wrong.");
    //        successful = false;
    //    }
    //    else
    //    {
    //        Debug.Log(www.text);
    //        stickerScores = www.text;

    //        successful = true;
    //    }
    //}

    //public void SendData()
    //{
    //    StartCoroutine(SendDataToFile());
    //}

    //public void GetData()
    //{
    //    StartCoroutine(GetDataFromFile());
    //}

    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
