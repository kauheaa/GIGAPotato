using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class scoreData

{
    private SumScript sum;
    private SubScript sub;
    private CountScript count;
    private MultiplyScript mult;
    private DivideScript div;
    private StickerBook book;

    // StarCounts of all categories in all worlds
    public int sumStarCount, sumJungleStarCount, sumSpaceStarCount, subStarCount, subJungleStarCount, subSpaceStarCount, multJungleStarCount, multSpaceStarCount, divJungleStarCount, divSpaceStarCount, countStarCount;

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

    public scoreData(StickerBook book)
    {
        // Load all starCounts
        sumStarCount = book.sumStarCount;
        sumJungleStarCount = book.sumJungleStarCount;
        sumSpaceStarCount = book.sumSpaceStarCount;
        subStarCount = book.subStarCount;
        subJungleStarCount = book.subStarCount;
        subSpaceStarCount = book.subStarCount;
        countStarCount = book.countStarCount;
        multJungleStarCount = book.multJungleStarCount;
        multSpaceStarCount = book.multSpaceStarCount;
        divJungleStarCount = book.divJungleStarCount;
        divSpaceStarCount = book.divSpaceStarCount;

        // Load Farm stickers
        appleStickerScore = book.appleStickerScore;
        basketStickerScore = book.basketStickerScore;
        pigStickerScore = book.pigStickerScore;

        carrotStickerScore = book.carrotStickerScore;
        bucketStickerScore = book.bucketStickerScore;
        bunnyStickerScore = book.bunnyStickerScore;

        threeCornStickerScore = book.threeCornStickerScore;
        twoCornStickerScore = book.twoCornStickerScore;
        lambStickerScore = book.lambStickerScore;

        // Load Jungle stickers
        bananaStickerScore = book.bananaStickerScore;
        clusterStickerScore = book.clusterStickerScore;
        monkeyStickerScore = book.monkeyStickerScore;

        coconutStickerScore = book.coconutStickerScore;
        ocularsStickerScore = book.ocularsStickerScore;
        slothStickerScore = book.slothStickerScore;

        lycheeStickerScore = book.lycheeStickerScore;
        pitahayaStickerScore = book.pitahayaStickerScore;
        frogStickerScore = book.frogStickerScore;

        avocadoStickerScore = book.avocadoStickerScore;
        toolStickerScore = book.toolStickerScore;
        tigerStickerScore = book.tigerStickerScore;

        // Load Space stickers
        asteroidStickerScore = book.asteroidStickerScore;
        blackholeStickerScore = book.blackholeStickerScore;
        llamaStickerScore = book.llamaStickerScore;

        starStickerScore = book.starStickerScore;
        planetStickerScore = book.planetStickerScore;
        cowStickerScore = book.cowStickerScore;

        flagStickerScore = book.flagStickerScore;
        rocketStickerScore = book.rocketStickerScore;
        laikaStickerScore = book.laikaStickerScore;

        driedfishStickerScore = book.driedfishStickerScore;
        octopusStickerScore = book.octopusStickerScore;
        catStickerScore = book.catStickerScore;
    }

    //public scoreData(SumScript sum)
    //{
    //    sumStarCount = sum.sumStarCount;
    //    sumJungleStarCount = sum.sumJungleStarCount;
    //    sumSpaceStarCount = sum.sumSpaceStarCount;

    //    appleStickerScore = sum.appleStickerScore;
    //    basketStickerScore = sum.basketStickerScore;
    //    pigStickerScore = sum.pigStickerScore;

    //    bananaStickerScore = sum.bananaStickerScore;
    //    clusterStickerScore = sum.clusterStickerScore;
    //    monkeyStickerScore = sum.monkeyStickerScore;

    //    asteroidStickerScore = sum.asteroidStickerScore;
    //    blackholeStickerScore = sum.blackholeStickerScore;
    //    llamaStickerScore = sum.llamaStickerScore;
    //}

    //public scoreData(SubScript sub)
    //{
    //    subStarCount = sub.subStarCount;
    //    subJungleStarCount = sub.subStarCount;
    //    subSpaceStarCount = sub.subStarCount;

    //    carrotStickerScore = sub.carrotStickerScore;
    //    bucketStickerScore = sub.bucketStickerScore;
    //    bunnyStickerScore = sub.bunnyStickerScore;

    //    coconutStickerScore = sub.coconutStickerScore;
    //    ocularsStickerScore = sub.ocularsStickerScore;
    //    slothStickerScore = sub.slothStickerScore;

    //    starStickerScore = sub.starStickerScore;
    //    planetStickerScore = sub.planetStickerScore;
    //    cowStickerScore = sub.cowStickerScore;
    //}

    //public scoreData(CountScript count)
    //{
    //    countStarCount = count.countStarCount;
    //    threeCornStickerScore = count.threeCornStickerScore;
    //    twoCornStickerScore = count.twoCornStickerScore;
    //    lambStickerScore = count.lambStickerScore;
    //}
    //public scoreData(MultiplyScript mult)
    //{
    //    multJungleStarCount = mult.multJungleStarCount;
    //    multSpaceStarCount = mult.multSpaceStarCount;

    //    lycheeStickerScore = mult.lycheeStickerScore;
    //    pitahayaStickerScore = mult.pitahayaStickerScore;
    //    frogStickerScore = mult.frogStickerScore;

    //    flagStickerScore = mult.flagStickerScore;
    //    rocketStickerScore = mult.rocketStickerScore;
    //    laikaStickerScore = mult.laikaStickerScore;
    //}
    //public scoreData(DivideScript div)
    //{
    //    divJungleStarCount = div.divJungleStarCount;
    //    divSpaceStarCount = div.divSpaceStarCount;

    //    avocadoStickerScore = div.avocadoStickerScore;
    //    toolStickerScore = div.toolStickerScore;
    //    tigerStickerScore = div.tigerStickerScore;

    //    driedfishStickerScore = div.driedfishStickerScore;
    //    octopusStickerScore = div.octopusStickerScore;
    //    catStickerScore = div.catStickerScore;
    //}






    /*public sumScoreData(SumScript sum)
    {
        sumScore = sum.sumScore;
    }

    
    public subScoreData(SubScript sub)
    {
        subScore = sub.subScore;


    }
    public divScoreData(DivideScript div)
    {
        divScore = div.divScore;


    }
    public multScoreData(MultiplyScript mult)
     {
         multScore = mult.multScore;


     }*/
}
