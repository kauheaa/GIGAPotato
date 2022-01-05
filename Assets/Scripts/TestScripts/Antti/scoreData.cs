using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class scoreData


{
    public int sumStarCount, appleStickerScore, basketStickerScore, pigStickerScore;
    public int sumJungleStarCount, bananaStickerScore, clusterStickerScore, monkeyStickerScore;
    public int sumSpaceStarCount, asteroidStickerScore, blackholeStickerScore, llamaStickerScore;

    public int subStarCount, carrotStickerScore, bucketStickerScore, bunnyStickerScore;
    public int subJungleStarCount, coconutStickerScore, ocularsStickerScore, slothStickerScore;
    public int subSpaceStarCount, starStickerScore, planetStickerScore, cowStickerScore;

    public int countStarCount, threeCornStickerScore, twoCornStickerScore, lambStickerScore;

    public int multJungleStarCount, lycheeStickerScore, pitahayaStickerScore, frogStickerScore;
    public int multSpaceStarCount, flagStickerScore, rocketStickerScore, laikaStickerScore;

    public int divJungleStarCount, avocadoStickerScore, toolStickerScore, tigerStickerScore;
    public int divSpaceStarCount, driedfishStickerScore, octopusStickerScore, catStickerScore;

    public scoreData(SumScript sum)
    {
        sumStarCount = sum.sumStarCount;
        sumJungleStarCount = sum.sumJungleStarCount;
        sumSpaceStarCount = sum.sumSpaceStarCount;

        appleStickerScore = sum.appleStickerScore;
        basketStickerScore = sum.basketStickerScore;
        pigStickerScore = sum.pigStickerScore;

        bananaStickerScore = sum.bananaStickerScore;
        clusterStickerScore = sum.clusterStickerScore;
        monkeyStickerScore = sum.monkeyStickerScore;

        asteroidStickerScore = sum.asteroidStickerScore;
        blackholeStickerScore = sum.blackholeStickerScore;
        llamaStickerScore = sum.llamaStickerScore;
    }

    public scoreData(SubScript sub)
    {
        subStarCount = sub.subStarCount;
        subJungleStarCount = sub.subStarCount;
        subSpaceStarCount = sub.subStarCount;

        carrotStickerScore = sub.carrotStickerScore;
        bucketStickerScore = sub.bucketStickerScore;
        bunnyStickerScore = sub.bunnyStickerScore;

        coconutStickerScore = sub.coconutStickerScore;
        ocularsStickerScore = sub.ocularsStickerScore;
        slothStickerScore = sub.slothStickerScore;

        starStickerScore = sub.starStickerScore;
        planetStickerScore = sub.planetStickerScore;
        cowStickerScore = sub.cowStickerScore;
    }

    public scoreData(CountScript count)
    {
        countStarCount = count.countStarCount;
        threeCornStickerScore = count.threeCornStickerScore;
        twoCornStickerScore = count.twoCornStickerScore;
        lambStickerScore = count.lambStickerScore;
    }
    public scoreData(MultiplyScript mult)
    {
        multJungleStarCount = mult.multJungleStarCount;
        multSpaceStarCount = mult.multSpaceStarCount;

        lycheeStickerScore = mult.lycheeStickerScore;
        pitahayaStickerScore = mult.pitahayaStickerScore;
        frogStickerScore = mult.frogStickerScore;

        flagStickerScore = mult.flagStickerScore;
        rocketStickerScore = mult.flagStickerScore;
        laikaStickerScore = mult.laikaStickerScore;
    }
    public scoreData(DivideScript div)
    {
        divJungleStarCount = div.divJungleStarCount;
        divSpaceStarCount = div.divSpaceStarCount;

        avocadoStickerScore = div.avocadoStickerScore;
        toolStickerScore = div.toolStickerScore;
        tigerStickerScore = div.tigerStickerScore;

        driedfishStickerScore = div.avocadoStickerScore;
        octopusStickerScore = div.toolStickerScore;
        catStickerScore = div.tigerStickerScore;
    }



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
