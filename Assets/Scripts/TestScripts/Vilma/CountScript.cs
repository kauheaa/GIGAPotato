using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

// "CountScript" is the same as "QuizManager"
public class CountScript : MonoBehaviour
{
    public StickerBook book;    // StickerBook
    public StarCount starCount; // StarCount
    public int levelIndex = 0;  // Defines level number in category
    public int worldIndex = 0;  // Defines world the level is in (1 = Farm, 2 = Jungle, 3 = Space)
    public GameObject levelButton1, levelButton2, levelButton3; // Category and Level buttons which' sprites change when category or level is completed
    public Sprite clearButton, completedButton; // Sprite for uncompleted and completed level button
    public GameObject Animal;                            // Character that reacts to answers
    [SerializeField] private Transform level, levelEnd;  // level and level end canvas that are opened and closed when score is 5
    public GameObject animatedLevelEnd;                  // LevelEnd with flying sticker and Next button, different if level has been completed before
    [SerializeField] public int sumScore = 0;            // Temporary level score, reset after unlocking sticker or restarting level
    public int task = 0;                                 // Tells the running number of the current task in level

    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public GameObject QuestionImg;
    public Text QuestionTxt;
    public Sprite QuestionSprite;
    public Text taskNumber; // This is shown as score +1 to imply the running number of task instead of score
    int totalQuestions = 0;
    public int score;

    public void CountStars()        // Checks StarCounts and updates stars
    {
        starCount.CountStarCount();
    }
    public void Load()              // Loads saved Stickers and StarCounts or creates empty save if there is none
    {
        book.LoadBook();
    }
    public void SetTaskNumber()
    {
        task = score + 1;
    }
    public void SetWorldIndex()
    {
        worldIndex = starCount.worldIndex;
    }
    public void SetLevelIndex(int level)
    {
        levelIndex = level;
    }

    // Gives stickers +1 at level end if they have < 1

    public void UpdateLevelButtons()
    {
        switch (worldIndex)
        {
            case 1:
                switch (levelIndex)
                {
                    case 1:
                        switch (book.threeCornStickerScore)
                        {
                            case 0: levelButton1.GetComponent<Image>().sprite = clearButton; break;
                            case 1: levelButton1.GetComponent<Image>().sprite = completedButton; break;
                        }
                        break;
                    case 2:
                        switch (book.twoCornStickerScore)
                        {
                            case 0: levelButton2.GetComponent<Image>().sprite = clearButton; break;
                            case 1: levelButton2.GetComponent<Image>().sprite = completedButton; break;
                        }
                        break;
                    case 3:
                        switch (book.lambStickerScore)
                        {
                            case 0: levelButton3.GetComponent<Image>().sprite = clearButton; break;
                            case 1: levelButton3.GetComponent<Image>().sprite = completedButton; break;
                        }
                        break;
                    default:
                        Debug.Log("No level index set");
                        break;
                }
                break;
        }
    }
    public void UpdateStickers()
    {
        switch (worldIndex)
        {
            case 1:
                switch (levelIndex)
                {
                    case 1:
                        book.UnlockThreeCorn();
                        book.OpenSpread2();
                        break;
                    case 2:
                        book.UnlockTwoCorn();
                        book.OpenSpread2();
                        break;
                    case 3:
                        book.OpenSpread2();
                        book.UnlockLamb();
                        break;
                    default:
                        Debug.Log("No level index set");
                        break;
                }
                break;
        }
        book.UpdateStickers();
        UpdateLevelButtons();
    }

    public void StartCount()
    {
        ResetScore();
        totalQuestions = QnA.Count;
        levelEnd.gameObject.SetActive(false);
        QuestionImg.SetActive(true);
        ResetTask();
    }

    public void correct()
    {
        score += 1;
        Animal.GetComponent<Animator>().SetBool("Happy", true);
        //QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    public void wrong()
    {

    }

    IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(1);
        taskNumber.text = task + "/ 5";
        ResetTask();
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
            options[i].GetComponent<Button>().interactable = true;
            options[i].GetComponent<Image>().sprite = options[i].GetComponent<CountAnswerScript>().blueButton;
            options[i].GetComponent<CountAnswerScript>().isCorrect = false;
            options[i].transform.GetChild(1).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            options[i].GetComponent<Animator>().SetBool("Correct", false);
            options[i].GetComponent<Animator>().SetBool("Incorrect", false);

            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<CountAnswerScript>().isCorrect = true;
            }
        }
    }



    void ResetTask()
    {
        //if(QnA.Count > 0)
        if(score >= 5)
        {
            UpdateStickers();
            CountStars();
            levelEnd.gameObject.SetActive(true);
            Animal.GetComponent<Animator>().SetBool("Dance", true);
            level.gameObject.SetActive(false);
        }
        else
        {
            Animal.GetComponent<Animator>().SetBool("Happy", false);
            currentQuestion = Random.Range(0, QnA.Count);
            //QuestionTxt.text = QnA[currentQuestion].Question;
            QuestionSprite = QnA[currentQuestion].Objects;
            QuestionImg.GetComponent<Image>().sprite = QuestionSprite;
            SetAnswers();
            SetTaskNumber();
            taskNumber.text = task + "/5";
        }
    }

    public void ResetScore()
    {
        score = 0;
        taskNumber.text = task + "/ 5";
    }
    private void Start()
    {
        SetWorldIndex();
        Load();
        completedButton = starCount.completedButton;
        clearButton = starCount.clearButton;
        CountStars();
        UpdateLevelButtons();
        totalQuestions = QnA.Count;
        levelEnd.gameObject.SetActive(false);
        QuestionImg.SetActive(true);
        ResetTask();
        SetTaskNumber();
        taskNumber.text = task + "/5";
    }

    void Update()
    {

    }
}
