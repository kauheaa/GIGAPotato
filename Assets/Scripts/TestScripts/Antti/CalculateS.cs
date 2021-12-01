using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateS : MonoBehaviour
{
    int firstValue, secondValue, tempValue, finalValue, Alternative1, Alternative2;
    public Text FirstValue, SecondValue, Function, Alt1, Alt2, Alt3;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {        


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
    

    public void SumFunction()
    {
        Calculate("Sum");
    }

    public void SubtractFunction()
    {
        Calculate("Subtract");
    }
    public void MultiplyFunction()
    {
        Calculate("Multiply");
    }
    public void DivideFunction()
    {
        Calculate("Divide");
    }


   


}