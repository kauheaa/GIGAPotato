using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// "CountScript" is your "QuizManager"
public class CountScript : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject Quizpanel;
    public GameObject GoPanel;

    // The sticker that will activate in stickerbook when level score is 5
    public GameObject sticker;

    public Text QuestionTxt;
    public Text ScoreTxt;

    int totalQuestions = 0;
    public int score;


    // Checks the score and unlocks the sticker in stickerbook when score is 5
    void Update()
    { 
            if (score >= 5)
        {
            sticker.gameObject.SetActive(true);
        }

        // Show the score real-time instead of only LevelEnd to check if sticker works correctly
        ScoreTxt.text = score + "/" + totalQuestions;
    }

    private void Start()
    {
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        Quizpanel.SetActive(true);
        generateQuestion();
    }


     //  I'm not sure if this is needed at all, or if ResetScore is enough on it's own. Depends on how replaying the level will work..?
     //  ResetScore will be needed when/if opening LevelEnd is bound to score; score needs to be reset before replaying, so LevelEnd is not opened at the level start.
     //  You can delete this if you feel it's unnecessary.
    public void StartCount()
    {
        ResetScore();
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        Quizpanel.SetActive(true);
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

/*
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<AnswerScript>().startColor;
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            
            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
*/
// Looks for sprites instead of color of the image I assume
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().sprite = options[i].GetComponent<CountAnswerScript>().blueButton;
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


    // ResetScore will be needed when/if opening LevelEnd is bound to score; score needs to be reset before replaying, so LevelEnd is not opened at the level start
    // and also so LevelEnd can be reopened when the level is replayed.
    public void ResetScore()
    {
        score = 0;
        ScoreTxt.text = score + "/" + totalQuestions;
    }
}
