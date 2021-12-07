using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class scoreData 
{
    public int score;



    public scoreData(CalculateS calc)
    {
        score = calc.score;    


    }
}
