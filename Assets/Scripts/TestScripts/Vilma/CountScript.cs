using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountScript : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject Quizpanel;
    public GameObject GoPanel;

    public GameObject sticker;

    public Text QuestionTxt;
    public Text ScoreTxt;

    int totalQuestions = 0;
    public int score;

    void Update()
    { 
            if (score >= 5)
        {
            sticker.gameObject.SetActive(true);
        }

        ScoreTxt.text = score + "/" + totalQuestions;
    }

    private void Start()
    {
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        generateQuestion();
    }

    public void StartCount()
    {
        ResetScore();
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        generateQuestion();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        Quizpanel.SetActive(false);
        GoPanel.SetActive(true);
 //       ScoreTxt.text = score + "/" + totalQuestions;
    }

    public void correct()
    {
        //when you are right
        score += 1;
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    public void wrong()
    {
        
        
    }

    IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(1);
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<CountAnswerScript>().startColor;
            options[i].GetComponent<CountAnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            
            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<CountAnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }


    }



    public void ResetScore()
    {
        score = 0;
        ScoreTxt.text = score + "/" + totalQuestions;
    }
}
