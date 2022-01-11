using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// "CountAnswerScript" is you "AnswerScript"
public class CountAnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public CountScript quizManager;

//  public Color startColor;

    // Defines blue, red and green button sprite
    public Sprite blueButton, redButton, greenButton;

    private void Start()
    {
        //      startColor = GetComponent<Image>().color;
        blueButton = GetComponent<Image>().sprite;
    }


/*
    public void Answer()
    {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    }
*/
    

// Instead of color, image source sprite is changed when answer is correct or incorrect
    public void Answer()
    {
        if(isCorrect)
        {
            GetComponent<Image>().sprite = greenButton;
            GetComponent<Button>().interactable = false;
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else
        {
            GetComponent<Image>().sprite = redButton;
            GetComponent<Button>().interactable = false;
            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    }

}
