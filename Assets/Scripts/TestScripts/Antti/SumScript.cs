using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SumScript : MonoBehaviour
{
    int firstValue, secondValue, tempValue, finalValue, Alternative1, Alternative2;
    [SerializeField] public int sumScore = 0;
    public Text FirstValue, SecondValue, Function, Alt1, Alt2, Alt3, AnswerSpot, scoreCount;
    public GameObject ONE, TWO, THREE, appleSpawn, apple, stickerOne, stickerTwo, stickerThree;
    public Button button1, button2, button3;
    [SerializeField] private Transform switchOff, switchOn;
    

    private void Start()
    {
        AnswerSpot.text = "?";
    }

    // Update is called once per frame
    void Update()
    {
        //   score = int.Parse(scoreCount.text);

        if (sumScore >= 5)
        {
            stickerOne.gameObject.SetActive(true);
        }
        if (sumScore >= 10)
        {
            stickerTwo.gameObject.SetActive(true);
        }
        if (sumScore >= 15)
        {
            stickerThree.gameObject.SetActive(true);
        }
    }

    public void SumFarm()
    {
        
        firstValue = Random.Range(1, 10);
        secondValue = Random.Range(1, 10);
        FirstValue.text = firstValue.ToString();
        SecondValue.text = secondValue.ToString();

        if (firstValue - secondValue < 0)
        {
            tempValue = secondValue;
            secondValue = firstValue;
            firstValue = tempValue;
        }
      
            Function.text = "+";
            finalValue = firstValue + secondValue;
        
     
    tempValue = Random.Range(2, 20);
        while(tempValue == finalValue)
        {
            tempValue = Random.Range(2, 20);
        }
Alternative1 = tempValue;

//Second Alternative
tempValue = Random.Range(2, 20);
while (tempValue == finalValue || (tempValue == Alternative1))
{
    tempValue = Random.Range(2, 20);
}
Alternative2 = tempValue;

tempValue = Random.Range(1, 6);
if (tempValue == 1)
{
    Alt1.text = finalValue.ToString(); Alt2.text = Alternative1.ToString(); Alt3.text = Alternative2.ToString();
}
if (tempValue == 2)
{
    Alt1.text = finalValue.ToString(); Alt2.text = Alternative2.ToString(); Alt3.text = Alternative1.ToString();
}
if (tempValue == 3)
{
    Alt1.text = Alternative1.ToString(); Alt2.text = finalValue.ToString(); Alt3.text = Alternative2.ToString();
}
if (tempValue == 4)
{
    Alt1.text = Alternative1.ToString(); Alt2.text = Alternative2.ToString(); Alt3.text = finalValue.ToString();
}
if (tempValue == 5)
{
    Alt1.text = Alternative2.ToString(); Alt2.text = finalValue.ToString(); Alt3.text = Alternative1.ToString();
}
if (tempValue == 6)
{
    Alt1.text = Alternative2.ToString(); Alt2.text = Alternative1.ToString(); Alt3.text = finalValue.ToString();
}





Debug.Log(firstValue + "  FUNCTION  " + secondValue + "=" + finalValue);
    }
    public void AltOne()
{
    if (Alt1.text == finalValue.ToString())
    {
        ONE.gameObject.SetActive(true);
            button1.interactable = false;
            StartCoroutine(Correct());
           

        }
}

public void AltTwo()
{

    if (Alt2.text == finalValue.ToString())
    {
        TWO.gameObject.SetActive(true);
            button2.interactable = false;
            StartCoroutine(Correct());

        }

}
public void AltThree()
{
    if (Alt3.text == finalValue.ToString())
    {
        THREE.gameObject.SetActive(true);
            button3.interactable = false;
            StartCoroutine(Correct());
        

    }
}
public void ResetV()
    {
        if(sumScore == 5)
        {
            switchOn.gameObject.SetActive(true);
            switchOff.gameObject.SetActive(false);
        }
        if (sumScore == 10)
        {
            switchOn.gameObject.SetActive(false);
            switchOff.gameObject.SetActive(true);
        }
        if (sumScore == 15)
        {
            switchOn.gameObject.SetActive(false);
            switchOff.gameObject.SetActive(true);
        }
        ONE.gameObject.SetActive(false);
        button1.interactable = true;
        TWO.gameObject.SetActive(false);
        button2.interactable = true;
        THREE.gameObject.SetActive(false);
        button3.interactable = true;
        AnswerSpot.text = "?";
        SumFarm();
    }
    IEnumerator Correct()
    {
        Score();       
        AnswerSpot.text = finalValue.ToString();       
        scoreCount.text = sumScore.ToString();
        yield return new WaitForSeconds(1f);
        ResetV();

       


    }
    void Score()
    {
        sumScore += 1;
    }
  
    public void SumJungle()
    {
        firstValue = Random.Range(1, 100);
        secondValue = Random.Range(1, 100);
        FirstValue.text = firstValue.ToString();
        SecondValue.text = secondValue.ToString();

        if (firstValue - secondValue < 0)
        {
            tempValue = secondValue;
            secondValue = firstValue;
            firstValue = tempValue;
        }

        Function.text = "+";
        finalValue = firstValue + secondValue;

    }
    public void SumSpace()
    {
        firstValue = Random.Range(1, 1000);
        secondValue = Random.Range(1, 1000);
        FirstValue.text = firstValue.ToString();
        SecondValue.text = secondValue.ToString();

        if (firstValue - secondValue < 0)
        {
            tempValue = secondValue;
            secondValue = firstValue;
            firstValue = tempValue;
        }

        Function.text = "+";
        finalValue = firstValue + secondValue;

    }

   public void StartFarm()
    {
        ResetV();
        SumFarm();
    }
    public void StartJungle()
    {
        ResetV();
        SumJungle();
    }
    public void StartSpace()
    {
        ResetV();
        SumSpace();
    }
    public void SaveScore()
    {
        saveScore.SaveSumScore(this);
    }
    public void LoadScore()
    {
        scoreData data = saveScore.LoadSumScore();
        sumScore = data.sumScore;
    }

}
