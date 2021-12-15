using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountAnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public CountScript quizManager;

    public Sprite blueButton, redButton, greenButton;

    private void Start()
    {
        blueButton = GetComponent<Image>().sprite;
    }

    public void Answer()
    {
        if(isCorrect)
        {
            GetComponent<Image>().sprite = greenButton;
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else
        {
            GetComponent<Image>().sprite = redButton;
            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    }

}
