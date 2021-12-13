using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class scoreData


{
    public int sumScore, subScore, divScore, multScore;

    public scoreData(SumScript sum)
    {
        sumScore = sum.sumScore;
        subScore = sum.subScore;
        divScore = sum.divScore;
        multScore = sum.multScore;


    }


    /*public sumScoreData(SumScript sum)
    {
        sumScore = sum.sumScore;


    
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
