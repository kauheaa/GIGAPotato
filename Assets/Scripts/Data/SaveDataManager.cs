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
                DatabaseManager.score = www.text;
                string[] score = www.text.Split('3'); // splits the text by character (single quote for a character, double for string)

                // picks apart saved score string and turns the characters into ints
                DatabaseManager.appleStickerScore = int.Parse(score[1]);
                DatabaseManager.basketStickerScore = int.Parse(score[2]);
                DatabaseManager.pigStickerScore = int.Parse(score[3]);
                DatabaseManager.carrotStickerScore = int.Parse(score[4]);
                DatabaseManager.bucketStickerScore = int.Parse(score[5]);
                DatabaseManager.bunnyStickerScore = int.Parse(score[6]);
                DatabaseManager.threeCornStickerScore = int.Parse(score[7]);
                DatabaseManager.twoCornStickerScore = int.Parse(score[8]);
                DatabaseManager.lambStickerScore = int.Parse(score[9]);
                DatabaseManager.bananaStickerScore = int.Parse(score[10]);
                DatabaseManager.clusterStickerScore = int.Parse(score[11]);
                DatabaseManager.monkeyStickerScore = int.Parse(score[12]);
                DatabaseManager.coconutStickerScore = int.Parse(score[13]);
                DatabaseManager.ocularsStickerScore = int.Parse(score[14]);
                DatabaseManager.slothStickerScore = int.Parse(score[15]);
                DatabaseManager.lycheeStickerScore = int.Parse(score[16]);
                DatabaseManager.pitahayaStickerScore = int.Parse(score[17]);
                DatabaseManager.frogStickerScore = int.Parse(score[18]);
                DatabaseManager.avocadoStickerScore = int.Parse(score[19]);
                DatabaseManager.toolStickerScore = int.Parse(score[20]);
                DatabaseManager.tigerStickerScore = int.Parse(score[21]);
                DatabaseManager.asteroidStickerScore = int.Parse(score[22]);
                DatabaseManager.blackholeStickerScore = int.Parse(score[23]);
                DatabaseManager.llamaStickerScore = int.Parse(score[24]);
                DatabaseManager.starStickerScore = int.Parse(score[25]);
                DatabaseManager.planetStickerScore = int.Parse(score[26]);
                DatabaseManager.cowStickerScore = int.Parse(score[27]);
                DatabaseManager.flagStickerScore = int.Parse(score[28]);
                DatabaseManager.rocketStickerScore = int.Parse(score[29]);
                DatabaseManager.laikaStickerScore = int.Parse(score[30]);
                DatabaseManager.driedfishStickerScore = int.Parse(score[31]);
                DatabaseManager.octopusStickerScore = int.Parse(score[32]);
                DatabaseManager.catStickerScore = int.Parse(score[33]);
                book.LoadBook();
                Debug.Log("Score saved:" + www.text + " stickerbook scores updated");
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