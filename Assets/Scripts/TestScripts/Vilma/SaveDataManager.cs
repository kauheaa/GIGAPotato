using System.Collections;
using UnityEngine;

public class SaveDataManager : MonoBehaviour
{
    public StickerBook book;
    public string username;


    public void SetDatabaseScore() // sets database score by combining all book sticker scores into a string
    {
        DatabaseManager.score = "3" + book.appleStickerScore + "3" + book.basketStickerScore + "3" + book.pigStickerScore + "3" + book.carrotStickerScore + "3" + book.bucketStickerScore + "3" + book.bunnyStickerScore + "3" + book.threeCornStickerScore + "3" + book.twoCornStickerScore + "3" + book.lambStickerScore + "3" + book.bananaStickerScore + "3" + book.clusterStickerScore + "3" + book.monkeyStickerScore + "3" + book.coconutStickerScore + "3" + book.ocularsStickerScore + "3" + book.slothStickerScore + "3" + book.lycheeStickerScore + "3" + book.pitahayaStickerScore + "3" + book.frogStickerScore + "3" + book.avocadoStickerScore + "3" + book.toolStickerScore + "3" + book.tigerStickerScore + "3" + book.asteroidStickerScore + "3" + book.blackholeStickerScore + "3" + book.llamaStickerScore + "3" + book.starStickerScore + "3" + book.planetStickerScore + "3" + book.cowStickerScore + "3" + book.flagStickerScore + "3" + book.rocketStickerScore + "3" + book.laikaStickerScore + "3" + book.driedfishStickerScore + "3" + book.octopusStickerScore + "3" + book.catStickerScore + "3";
    }

    public void CallSaveData()      // sets database score by combining all book sticker scores into a string, saves score into database for logged in username
    {
        SetDatabaseScore();
        StartCoroutine(SavePlayerData());
    }


    IEnumerator SavePlayerData()    // saves database score as a string into database for logged in username
    {
        if (DatabaseManager.username != null)
        { 
            WWWForm form = new WWWForm();
            form.AddField("name", DatabaseManager.username);
            form.AddField("score", DatabaseManager.score);
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
        else
        {
            Debug.Log("Login to save");
        }
    }

    private void Awake()
    {
        Debug.Log("SaveDataManager woke up. DatabaseScore is " + DatabaseManager.score);
    }

}