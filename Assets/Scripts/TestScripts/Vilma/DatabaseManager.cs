using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DatabaseManager
{
    public static string username;
    public static string score;
    public static int avatarIndex;

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

    public static bool LoggedIn { get { return username != null; } }

    public static void LogOut()
    {
        username = null;
    }

}
