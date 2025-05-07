using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DatabaseManager
{
    public static string username;
    public static string score;
    public static int avatarIndex;

    public static readonly string DefaultUsername = "DEFAULT_USER";
    public static bool LoggedIn => username != null && username != DefaultUsername;

    // Farm sticker scores
    public static int appleStickerScore = 0;
    public static int basketStickerScore = 0;
    public static int pigStickerScore = 0;

    public static int carrotStickerScore = 0;
    public static int bucketStickerScore = 0;
    public static int bunnyStickerScore = 0;

    public static int threeCornStickerScore = 0;
    public static int twoCornStickerScore = 0;
    public static int lambStickerScore = 0;

    // Jungle sticker scores
    public static int bananaStickerScore = 0;
    public static int clusterStickerScore = 0;
    public static int monkeyStickerScore = 0;

    public static int coconutStickerScore = 0;
    public static int ocularsStickerScore = 0;
    public static int slothStickerScore = 0;

    public static int lycheeStickerScore = 0;
    public static int pitahayaStickerScore = 0;
    public static int frogStickerScore = 0;

    public static int avocadoStickerScore = 0;
    public static int toolStickerScore = 0;
    public static int tigerStickerScore = 0;

    // Space sticker scores
    public static int asteroidStickerScore = 0;
    public static int blackholeStickerScore = 0;
    public static int llamaStickerScore = 0;

    public static int starStickerScore = 0;
    public static int planetStickerScore = 0;
    public static int cowStickerScore = 0;

    public static int flagStickerScore = 0;
    public static int rocketStickerScore = 0;
    public static int laikaStickerScore = 0;

    public static int driedfishStickerScore = 0;
    public static int octopusStickerScore = 0;
    public static int catStickerScore = 0;

 /*{ get { return username != null; } }*/

    public static void LogOut()
    {
        string key = "user_" + DefaultUsername;
        if (PlayerPrefs.HasKey(key))
        {
            score = PlayerPrefs.GetString(key);
        }
        else
        {
            score = "3030303030303030303030303030303030303030303030303030303030303030303";

		}
        username = null;
    }

    public static void LoadDefaultScore()
    {
        string key = "user_data_" + DefaultUsername;
        score = PlayerPrefs.GetString(key, "3030303030303030303030303030303030303030303030303030303030303030303");
		// splits the text by character (single quote for a character, double for string)
		string[] scoreString = DatabaseManager.score.Split('3');
		Debug.Log($"Load score {DatabaseManager.score}");

		// picks apart saved scoreString string and turns the characters into ints
		DatabaseManager.appleStickerScore = int.Parse(scoreString[1]);
		DatabaseManager.basketStickerScore = int.Parse(scoreString[2]);
		DatabaseManager.pigStickerScore = int.Parse(scoreString[3]);
		DatabaseManager.carrotStickerScore = int.Parse(scoreString[4]);
		DatabaseManager.bucketStickerScore = int.Parse(scoreString[5]);
		DatabaseManager.bunnyStickerScore = int.Parse(scoreString[6]);
		DatabaseManager.threeCornStickerScore = int.Parse(scoreString[7]);
		DatabaseManager.twoCornStickerScore = int.Parse(scoreString[8]);
		DatabaseManager.lambStickerScore = int.Parse(scoreString[9]);
		DatabaseManager.bananaStickerScore = int.Parse(scoreString[10]);
		DatabaseManager.clusterStickerScore = int.Parse(scoreString[11]);
		DatabaseManager.monkeyStickerScore = int.Parse(scoreString[12]);
		DatabaseManager.coconutStickerScore = int.Parse(scoreString[13]);
		DatabaseManager.ocularsStickerScore = int.Parse(scoreString[14]);
		DatabaseManager.slothStickerScore = int.Parse(scoreString[15]);
		DatabaseManager.lycheeStickerScore = int.Parse(scoreString[16]);
		DatabaseManager.pitahayaStickerScore = int.Parse(scoreString[17]);
		DatabaseManager.frogStickerScore = int.Parse(scoreString[18]);
		DatabaseManager.avocadoStickerScore = int.Parse(scoreString[19]);
		DatabaseManager.toolStickerScore = int.Parse(scoreString[20]);
		DatabaseManager.tigerStickerScore = int.Parse(scoreString[21]);
		DatabaseManager.asteroidStickerScore = int.Parse(scoreString[22]);
		DatabaseManager.blackholeStickerScore = int.Parse(scoreString[23]);
		DatabaseManager.llamaStickerScore = int.Parse(scoreString[24]);
		DatabaseManager.starStickerScore = int.Parse(scoreString[25]);
		DatabaseManager.planetStickerScore = int.Parse(scoreString[26]);
		DatabaseManager.cowStickerScore = int.Parse(scoreString[27]);
		DatabaseManager.flagStickerScore = int.Parse(scoreString[28]);
		DatabaseManager.rocketStickerScore = int.Parse(scoreString[29]);
		DatabaseManager.laikaStickerScore = int.Parse(scoreString[30]);
		DatabaseManager.driedfishStickerScore = int.Parse(scoreString[31]);
		DatabaseManager.octopusStickerScore = int.Parse(scoreString[32]);
		DatabaseManager.catStickerScore = int.Parse(scoreString[33]);
	}

}
