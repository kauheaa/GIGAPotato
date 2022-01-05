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
    public GameObject QuestionImg;
    public GameObject GoPanel;
    public Text QuestionTxt;
    //public GameObject QuestionImg;
    public Sprite QuestionSprite;
    public Text ScoreTxt;
    int totalQuestions = 0;
    public int score;
    // These are needed for Stickers, Starcount and saving
    public int levelIndex = 0;
    [SerializeField] public int countStarCount = 0;
    [SerializeField] public int threeCornStickerScore = 0;
    [SerializeField] public int twoCornStickerScore = 0;
    [SerializeField] public int lambStickerScore = 0;
    public GameObject stickerOne, stickerTwo, stickerThree;
    public Sprite oneStar, twoStar, threeStar;
    public GameObject countStars, menuStars;
    public GameObject Animal;

    // saves sticker score and updates it to all instances of same script in the scene
    public void SaveScore()
    {
        saveScore.SaveCountScore(this);
        CountScript[] tempArray = GameObject.FindObjectsOfType<CountScript>();
        foreach (CountScript i in tempArray)
        {
            i.LoadScore();
        }

    }
    // loads sticker scores
    public void LoadScore()
    {
        scoreData data = saveScore.LoadCountScore();
        countStarCount = data.countStarCount;
        threeCornStickerScore = data.threeCornStickerScore;
        twoCornStickerScore = data.twoCornStickerScore;
        lambStickerScore = data.lambStickerScore;
        Debug.Log("corn: " + threeCornStickerScore + " another corn: " + twoCornStickerScore + " lamb: " + lambStickerScore);

    }
    // gives level an index that separates it from other levels; added in inspector
    public void SetLevelIndex(int index)
    {
        levelIndex = index;
    }
    // Gives stickers +1 at level end if they have < 1
    public void CheckStickers()
    {
        if (score >= 5)
        {
            switch (levelIndex)
            {
                case 1:
                    if (threeCornStickerScore < 1)
                    {
                        threeCornStickerScore += 1;
                        Debug.Log("Corn unlocked");
                    }
                    break;
                case 2:
                    if (twoCornStickerScore < 1)
                    {
                        twoCornStickerScore += 1;
                        Debug.Log("More Corn unlocked");
                    }
                    break;
                case 3:
                    if (lambStickerScore < 1)
                    {
                        lambStickerScore += 1;
                        Debug.Log("Lamb unlocked");
                    }
                    break;
                default:
                    Debug.Log("No level index set");
                    break;
            }

        }
    }
    // Unlocks stickers if their score is 1
    public void UnlockStickers()
    {

        if (threeCornStickerScore == 1)
        {
            stickerOne.gameObject.SetActive(true);
        }
        if (twoCornStickerScore == 1)
        {
            stickerTwo.gameObject.SetActive(true);
        }
        if (lambStickerScore == 1)
        {
            stickerThree.gameObject.SetActive(true);
        }
    }
    // Unlocks a star each time a sticker is unlocked
    public void UnlockStars()
    {
        countStarCount = threeCornStickerScore + twoCornStickerScore + lambStickerScore;

        if (countStarCount == 1)
        {
            countStars.GetComponent<Image>().sprite = oneStar;
            menuStars.GetComponent<Image>().sprite = oneStar;
        }
        if (countStarCount == 2)
        {
            countStars.GetComponent<Image>().sprite = twoStar;
            menuStars.GetComponent<Image>().sprite = twoStar;
        }
        if (countStarCount == 3)
        {
            countStars.GetComponent<Image>().sprite = threeStar;
            menuStars.GetComponent<Image>().sprite = threeStar;
        }
    }



    private void Start()
    {
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        QuestionImg.SetActive(true);
        generateQuestion();
        LoadScore();
    }

    void Update()
    {

        CheckStickers();
        UnlockStickers();
        UnlockStars();
        // Show the score real-time instead of only LevelEnd to check if sticker works correctly
        ScoreTxt.text = score + "/" + totalQuestions;
    }

    //  I'm not sure if this is needed at all, or if ResetScore is enough on it's own. Depends on how replaying the level will work..?
    //  ResetScore will be needed when/if opening LevelEnd is bound to score; score needs to be reset before replaying, so LevelEnd is not opened at the level start.
    //  You can delete this if you feel it's unnecessary.
    public void StartCount()
    {
        ResetScore();
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        QuestionImg.SetActive(true);
        generateQuestion();
    }


    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        QuestionImg.SetActive(false);
        GoPanel.SetActive(true);
 //       ScoreTxt.text = score + "/" + totalQuestions;
    }

    public void correct()
    {
        //when you are right
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
        //if(QnA.Count > 0)
        if(score <= 4)
        {
            Animal.GetComponent<Animator>().SetBool("Happy", false);
            currentQuestion = Random.Range(0, QnA.Count);
            //QuestionTxt.text = QnA[currentQuestion].Question;
            QuestionSprite = QnA[currentQuestion].Objects;
            QuestionImg.GetComponent<Image>().sprite = QuestionSprite;
            SetAnswers();

            CheckStickers();
        }
        else
        {
            Animal.GetComponent<Animator>().SetBool("Dance", true);
            Debug.Log("Out of Questions");
            GameOver();

            CheckStickers();
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
