using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class scoreData


{
    public int sumStarCount, appleStickerScore, basketStickerScore, pigStickerScore;
    public int subStarCount, carrotStickerScore, bucketStickerScore, bunnyStickerScore;
    public int countStarCount, threeCornStickerScore, twoCornStickerScore, lambStickerScore;

    public scoreData(SumScript sum)
    {
        sumStarCount = sum.sumStarCount;
        appleStickerScore = sum.appleStickerScore;
        basketStickerScore = sum.basketStickerScore;
        pigStickerScore = sum.pigStickerScore;
    }

    public scoreData(SubScript sub)
    {
        subStarCount = sub.subStarCount;
        carrotStickerScore = sub.carrotStickerScore;
        bucketStickerScore = sub.bucketStickerScore;
        bunnyStickerScore = sub.bunnyStickerScore;
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
        {
            sumStarCount = mult.sumStarCount;
            appleStickerScore = mult.appleStickerScore;
            basketStickerScore = mult.basketStickerScore;
            pigStickerScore = mult.pigStickerScore;
        }
    }
    public scoreData(DivideScript div)
    {
        sumStarCount = div.sumStarCount;
        appleStickerScore = div.appleStickerScore;
        basketStickerScore = div.basketStickerScore;
        pigStickerScore = div.pigStickerScore;
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
