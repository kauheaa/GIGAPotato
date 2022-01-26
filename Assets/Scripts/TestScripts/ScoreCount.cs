using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    [SerializeField] public int score = 0;
    [SerializeField] public int score2 = 0;
    [SerializeField] public int score3 = 0;
    public Text scoreCount;
    private SumScript sum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = int.Parse(scoreCount.text);
       


    }
    public void Score()
    {
        score += 1;
        scoreCount.text = score.ToString();
    }
}
