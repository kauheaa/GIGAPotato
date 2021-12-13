using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateS : MonoBehaviour
{
    int firstValue, secondValue, tempValue, finalValue, Alternative1, Alternative2;
    [SerializeField] public int score = 0;
    [SerializeField] public int score2 = 0;
    [SerializeField] public int score3 = 0;


    public Text FirstValue, SecondValue, Function, Alt1, Alt2, Alt3, AnswerSpot, scoreCount;
    public GameObject ONE, TWO, THREE, appleSpawn, apple, stickerOne, stickerTwo, stickerThree;
    
 
    

    // Start is called before the first frame update
    void Start()
    {
        AnswerSpot.text = "?";    
      
        


    }

    // Update is called once per frame
    void Update()
    {
     //   score = int.Parse(scoreCount.text);

        if (score >= 5)
        {
            stickerOne.gameObject.SetActive(true);
        }
        if (score2 >= 5)
        {
            stickerTwo.gameObject.SetActive(true);
        }
        if (score3 >= 5)
        {
            stickerThree.gameObject.SetActive(true);
        }
        if (score == 6)
        {
            score -= 5;
        }
    }
   

    public void AddFunction()
    {
        Debug.Log("Function");
    }

    public void Calculate(string operation)
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

        if (operation == "Sum")
        {
           
            Function.text = "+";
            finalValue = firstValue + secondValue;
            
            
        }
        if (operation == "Subtract")
        {
            Function.text = "-";
            finalValue = firstValue - secondValue;
           
        }
        if (operation == "Multiply")
        {
            Function.text = "*";
            finalValue = firstValue * secondValue;
           
        }
        if (operation == "Divide")
        {
            Function.text = "/";
            finalValue = firstValue / secondValue;
            
        }

        // FIRST ALTERNATIVE
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
        if(tempValue == 1)
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
            Correct();
        
        }
    }

        public void AltTwo()
    {
        
        if(Alt2.text == finalValue.ToString())
        {
            TWO.gameObject.SetActive(true);
            Correct();
       
        }

    }
    public void AltThree()
    {
        if (Alt3.text == finalValue.ToString())
        {
            THREE.gameObject.SetActive(true);
            Correct();
      
        }
    }

        public void SumFunction()
    {
        Reset();
        Calculate("Sum");
        AppleDrop();
    }

    public void SubtractFunction()
    {
        Reset();
        Calculate("Subtract");
        AppleDrop();
    }
    public void MultiplyFunction()
    {
        Reset();
        Calculate("Multiply");
        AppleDrop();    
    }
    public void DivideFunction()
    {
        Reset();
        Calculate("Divide");
        AppleDrop();
    }
    
    public void Reset()
    {
        ONE.gameObject.SetActive(false);
        TWO.gameObject.SetActive(false);
        THREE.gameObject.SetActive(false);
        AnswerSpot.text = "?";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Alt1"))
        {
            Correct();
            Debug.Log(finalValue);
        }

    }
    public void Correct()
    {
       
        AnswerSpot.text = finalValue.ToString();
        Score();
        scoreCount.text = score.ToString();

        
    }
    public void Score()
    {
        score += 1;
    }

    /*public void SaveScore()
    {
        saveScore.SaveSumScore(S);
    }
    public void LoadScore()
    {
        scoreData data = saveScore.LoadSumScore();        
        score = data.sumScore;
    }*/


    public void AppleDrop()
    {
        if (finalValue == 1)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 2)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 3)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>(); 
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 4)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 5)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 6)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 7)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile7 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 8)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile8 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile7 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 9)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile9 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile8 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile7 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();

        }
        if (finalValue == 10)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile10 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile9 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile8 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile7 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 11)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile11 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile10 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile9 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile8 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile7 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 12)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile12 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile11 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile10 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile9 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile8 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile7 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 13)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile13 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile12 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile11 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile10 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile9 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile8 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile7 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 14)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile14 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile13 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile12 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile11 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile10 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile9 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile8 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile7 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
    
        if (finalValue == 15)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile15 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile14 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile13 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile12 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile11 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile10 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile9 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile8 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile7 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 16)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile16 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile15 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile14 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile13 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile12 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile11 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile10 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile9 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile8 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile7 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
            if (finalValue == 17)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
                GameObject projectile17 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile16 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile15 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile14 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile13 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile12 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile11 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile10 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile9 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile8 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile7 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
                GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>();
            }
        if (finalValue == 18)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile18 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile17 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile16 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile15 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile14 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile13 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile12 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile11 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile10 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile9 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile8 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile7 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 19)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile19 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile18 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile17 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile16 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile15 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile14 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile13 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile12 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile11 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile10 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile9 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile8 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile7 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
        if (finalValue == 20)
        {
            GameObject projectile = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile20 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile19 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile18 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile17 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile16 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile15 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile14 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile13 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile12 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile11 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile10 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile9 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile8 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile7 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile6 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile5 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile4 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile2 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
            GameObject projectile3 = Instantiate(apple, appleSpawn.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>();
        }
    }

   




}