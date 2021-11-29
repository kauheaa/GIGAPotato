using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateS : MonoBehaviour
{
    int firstValue, secondValue, tempValue, finalValue;


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

        if (firstValue - secondValue < 0)
        {
            tempValue = secondValue;
            secondValue = firstValue;
            firstValue = tempValue;
        }

        if (operation == "Sum")
        {
            finalValue = firstValue + secondValue;
        }
        if (operation == "Subtract")
        {
            finalValue = firstValue - secondValue;
        }
        if (operation == "Multiply")
        {
            finalValue = firstValue * secondValue;
        }
        if (operation == "Divide")
        {
            finalValue = firstValue / secondValue;
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