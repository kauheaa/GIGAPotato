using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class BookData
{
    public WriteToFile writeToFile;
    public string stickerScores;


    public string playerName;

    // StarCounts of all categories in all worlds
    public int sumFarmStarCount, sumJungleStarCount, sumSpaceStarCount;
    public int subFarmStarCount, subJungleStarCount, subSpaceStarCount;
    public int countFarmStarCount, countJungleStarCount, countSpaceStarCount;
    public int multJungleStarCount, multSpaceStarCount;
    public int divJungleStarCount, divSpaceStarCount;

    // Farm sticker scores
    public int appleStickerScore, basketStickerScore, pigStickerScore;
    public int carrotStickerScore, bucketStickerScore, bunnyStickerScore;
    public int threeCornStickerScore, twoCornStickerScore, lambStickerScore;

    // Jungle sticker scores
    public int bananaStickerScore, clusterStickerScore, monkeyStickerScore;
    public int coconutStickerScore, ocularsStickerScore, slothStickerScore;
    public int lycheeStickerScore, pitahayaStickerScore, frogStickerScore;
    public int avocadoStickerScore, toolStickerScore, tigerStickerScore;

    // Space sticker scores
    public int asteroidStickerScore, blackholeStickerScore, llamaStickerScore;
    public int starStickerScore, planetStickerScore, cowStickerScore;
    public int flagStickerScore, rocketStickerScore, laikaStickerScore;
    public int driedfishStickerScore, octopusStickerScore, catStickerScore;

    public void LoadData()
    {
        stickerScores = writeToFile.stickerScores;
        sumFarmStarCount = (int)Char.GetNumericValue(stickerScores[0]);
        sumJungleStarCount = (int)Char.GetNumericValue(stickerScores[1]);
        sumSpaceStarCount = (int)Char.GetNumericValue(stickerScores[2]);
        subFarmStarCount = (int)Char.GetNumericValue(stickerScores[3]);
        subJungleStarCount = (int)Char.GetNumericValue(stickerScores[4]);
        subSpaceStarCount = (int)Char.GetNumericValue(stickerScores[5]);
        countFarmStarCount = (int)Char.GetNumericValue(stickerScores[6]);
        countJungleStarCount = (int)Char.GetNumericValue(stickerScores[7]);
        countSpaceStarCount = (int)Char.GetNumericValue(stickerScores[8]);
        multJungleStarCount = (int)Char.GetNumericValue(stickerScores[9]);
        multSpaceStarCount = (int)Char.GetNumericValue(stickerScores[10]);
        divJungleStarCount = (int)Char.GetNumericValue(stickerScores[11]);
        divSpaceStarCount = (int)Char.GetNumericValue(stickerScores[12]);

        appleStickerScore = (int)Char.GetNumericValue(stickerScores[13]);
        basketStickerScore = (int)Char.GetNumericValue(stickerScores[14]);
        pigStickerScore = (int)Char.GetNumericValue(stickerScores[15]);
        carrotStickerScore = (int)Char.GetNumericValue(stickerScores[16]);
        bucketStickerScore = (int)Char.GetNumericValue(stickerScores[17]);
        bunnyStickerScore = (int)Char.GetNumericValue(stickerScores[18]);
        threeCornStickerScore = (int)Char.GetNumericValue(stickerScores[19]);
        twoCornStickerScore = (int)Char.GetNumericValue(stickerScores[20]);
        lambStickerScore = (int)Char.GetNumericValue(stickerScores[21]);

        bananaStickerScore = (int)Char.GetNumericValue(stickerScores[22]);
        clusterStickerScore = (int)Char.GetNumericValue(stickerScores[23]);
        monkeyStickerScore = (int)Char.GetNumericValue(stickerScores[24]);
        coconutStickerScore = (int)Char.GetNumericValue(stickerScores[25]);
        ocularsStickerScore = (int)Char.GetNumericValue(stickerScores[26]);
        slothStickerScore = (int)Char.GetNumericValue(stickerScores[27]);
        lycheeStickerScore = (int)Char.GetNumericValue(stickerScores[28]);
        pitahayaStickerScore = (int)Char.GetNumericValue(stickerScores[29]);
        frogStickerScore = (int)Char.GetNumericValue(stickerScores[30]);
        avocadoStickerScore = (int)Char.GetNumericValue(stickerScores[31]);
        toolStickerScore = (int)Char.GetNumericValue(stickerScores[32]);
        tigerStickerScore = (int)Char.GetNumericValue(stickerScores[33]);

        asteroidStickerScore = (int)Char.GetNumericValue(stickerScores[34]);
        blackholeStickerScore = (int)Char.GetNumericValue(stickerScores[35]);
        llamaStickerScore = (int)Char.GetNumericValue(stickerScores[36]);
        starStickerScore = (int)Char.GetNumericValue(stickerScores[37]);
        planetStickerScore = (int)Char.GetNumericValue(stickerScores[38]);
        cowStickerScore = (int)Char.GetNumericValue(stickerScores[39]);
        flagStickerScore = (int)Char.GetNumericValue(stickerScores[40]);
        rocketStickerScore = (int)Char.GetNumericValue(stickerScores[41]);
        laikaStickerScore = (int)Char.GetNumericValue(stickerScores[42]);
        driedfishStickerScore = (int)Char.GetNumericValue(stickerScores[43]);
        octopusStickerScore = (int)Char.GetNumericValue(stickerScores[44]);
        catStickerScore = (int)Char.GetNumericValue(stickerScores[45]);

    }

    //public BookData (StickerBook book)
    //{
    //    playerName = book.playerName;

    //    sumFarmStarCount = book.sumFarmStarCount;
    //    sumJungleStarCount = book.sumJungleStarCount;
    //    sumSpaceStarCount = book.sumSpaceStarCount;
    //    subFarmStarCount = book.subFarmStarCount;
    //    subJungleStarCount = book.subJungleStarCount;
    //    subSpaceStarCount = book.subSpaceStarCount;
    //    countFarmStarCount = book.countFarmStarCount;
    //    countJungleStarCount = book.countJungleStarCount;
    //    countSpaceStarCount = book.countSpaceStarCount;
    //    multJungleStarCount = book.multJungleStarCount;
    //    multSpaceStarCount = book.multSpaceStarCount;
    //    divJungleStarCount = book.divJungleStarCount;
    //    divSpaceStarCount = book.divSpaceStarCount;

    //    appleStickerScore = book.appleStickerScore;
    //    basketStickerScore = book.basketStickerScore;
    //    pigStickerScore = book.pigStickerScore;
    //    carrotStickerScore = book.carrotStickerScore;
    //    bucketStickerScore = book.bucketStickerScore;
    //    bunnyStickerScore = book.bunnyStickerScore;
    //    threeCornStickerScore = book.threeCornStickerScore;
    //    twoCornStickerScore = book.twoCornStickerScore;
    //    lambStickerScore = book.lambStickerScore;

    //    bananaStickerScore = book.bananaStickerScore;
    //    clusterStickerScore = book.clusterStickerScore;
    //    monkeyStickerScore = book.monkeyStickerScore;
    //    coconutStickerScore = book.coconutStickerScore;
    //    ocularsStickerScore = book.ocularsStickerScore;
    //    slothStickerScore = book.slothStickerScore;
    //    lycheeStickerScore = book.lycheeStickerScore;
    //    pitahayaStickerScore = book.pitahayaStickerScore;
    //    frogStickerScore = book.frogStickerScore;
    //    avocadoStickerScore = book.avocadoStickerScore;
    //    toolStickerScore = book.toolStickerScore;
    //    tigerStickerScore = book.tigerStickerScore;

    //    asteroidStickerScore = book.asteroidStickerScore;
    //    blackholeStickerScore = book.blackholeStickerScore;
    //    llamaStickerScore = book.llamaStickerScore;
    //    starStickerScore = book.starStickerScore;
    //    planetStickerScore = book.planetStickerScore;
    //    cowStickerScore = book.cowStickerScore;
    //    flagStickerScore = book.flagStickerScore;
    //    rocketStickerScore = book.rocketStickerScore;
    //    laikaStickerScore = book.laikaStickerScore;
    //    driedfishStickerScore = book.driedfishStickerScore;
    //    octopusStickerScore = book.octopusStickerScore;
    //    catStickerScore = book.catStickerScore;
    //}


}
