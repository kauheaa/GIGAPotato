using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SumScript : MonoBehaviour
{
    public StickerBook book; // StickerBook
    public StarCount starCount; // StarCount

    // MENU
    public GameObject levelButton1, levelButton2, levelButton3; // Category and Level buttons which' sprites change when category or level is completed
    public Sprite clearButton, completedButton; // Sprite for uncompleted and completed level button

    // LEVEL
    public int worldIndex = 0;                           // Number defining world (1 = Farm, 2 = Jungle, 3 = Space)
    public int levelIndex = 0;                           // Number of level in category
    public GameObject Animal;                            // Character that reacts to answers
    [SerializeField] private Transform level, levelEnd, levelFail;  // level and level end canvas that are opened and closed when score is 5
    public GameObject animatedLevelEnd;                  // LevelEnd with flying sticker and Next button, different if level has been completed before
    [SerializeField] public int sumScore = 0;            // Temporary level score, reset after unlocking sticker or restarting level
    [SerializeField] public int wrongScore = 0;
    public int task = 0;                                 // Tells the running number of the current task in level

    public GameObject scoreStars;//-------------------------------------------------------------------------------------------------------------------------------------------------------T�M��������������

    // TASK
    int firstValue, secondValue, tempValue, finalValue, Alternative1, Alternative2;     // Task calculation values
    public Text FirstValue, SecondValue, Function, AnswerSpot, taskNumber;              // Text boxes for task calculation values

    // ANSWER BUTTONS
    public Text Alt1, Alt2, Alt3;                       // Text boxes for answer option values
    public Button button1, button2, button3;            // Task answer buttons
    public GameObject ONE, TWO, THREE;                  // Answer button's children image object that are unlocked when answer is clicked, sprite changes to red or green
    public Sprite blueButton, redButton, greenButton;   // Sprites for answer buttons

    // COUNTABLE OBJECT
    public GameObject firstObjectSlot;      // Countable object that changes based on task's firstValue
    public GameObject secondObjectSlot;     // Countable object that changes based on task's secondValue
    public Sprite[] objectSprite;           // List of countable object sprites for different numbers

    public void CountStars()                    // Checks StarCounts and updates stars
    {
        starCount.SumStarCount();
    }
    public void Load()                  // Loads saved Stickers and StarCounts or creates empty save if there is none
    {
        book.LoadBook();
    }
    public void SetTaskNumber()
    {
        task = sumScore + 1;
    }

    public void SetWorldIndex()
    {
        worldIndex = starCount.worldIndex;
    }
    public void SetLevelIndex(int level)
    {
        levelIndex = level;
    }

    public void ResetScore() // resets temporart level score //---------------------------------------------------------------------T�M��
    {
        sumScore = 0;
        wrongScore = 0;
        if (worldIndex > 1)
        {
            starCount.resetLevelScore();
            starCount.levelScoreStars();
        }
    }

    public void Score() // score defines when level end pops up //---------------------------------------------------------------------T�M��
    {
        sumScore += 1;
        if (worldIndex > 1)
        {
            starCount.addLevelScore();
            starCount.levelScoreStars();
        }
        SetTaskNumber();
    }

    public void WrongScore() //----------------------------------------------------------------------------------------------------------T�M��
    {
        if (sumScore > 0)
        {
            switch (worldIndex)
            {

                case 2:
                    sumScore -= 1;
                    starCount.subLevelScore();
                    starCount.levelScoreStars();
                    break;
                case 3:
                    sumScore -= 1;
                    starCount.subLevelScore();
                    starCount.levelScoreStars();
                    break;

            }
        }


    }

    public void ChooseObject() // Chooses sprite from list matching the numbers presented in task
    {
        if (worldIndex == 1)
        {
            for (int i = 0; i < objectSprite.Length; i++)
            {
                //FIRST CALCULATION OBJECT SPRITE
                switch (firstValue) //first sprite when first value is 10 or smaller
                {
                    case 0:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[0];
                        break;
                    case 1:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[1];
                        break;
                    case 2:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[2];
                        break;
                    case 3:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[3];
                        break;
                    case 4:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[4];
                        break;
                    case 5:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[5];
                        break;
                    case 6:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[6];
                        break;
                    case 7:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[7];
                        break;
                    case 8:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[8];
                        break;
                    case 9:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[9];
                        break;
                    case 10:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[10];
                        break;
                    case 11:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[11];
                        break;
                    case 12:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[12];
                        break;
                    case 13:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[13];
                        break;
                    case 14:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[14];
                        break;
                    case 15:
                        firstObjectSlot.GetComponent<Image>().sprite = objectSprite[15];
                        break;
                }

                //SECOND OBJECT SPRITE
                switch (secondValue) //second sprite when first value is 10 or smaller
                {
                    case 0:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[0];
                        break;
                    case 1:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[1];
                        break;
                    case 2:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[2];
                        break;
                    case 3:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[3];
                        break;
                    case 4:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[4];
                        break;
                    case 5:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[5];
                        break;
                    case 6:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[6];
                        break;
                    case 7:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[7];
                        break;
                    case 8:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[8];
                        break;
                    case 9:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[9];
                        break;
                    case 10:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[10];
                        break;
                    case 11:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[11];
                        break;
                    case 12:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[12];
                        break;
                    case 13:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[13];
                        break;
                    case 14:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[14];
                        break;
                    case 15:
                        secondObjectSlot.GetComponent<Image>().sprite = objectSprite[15];
                        break;
                }
            }
            //Debug.Log("firstvalue: " + firstValue + ", secondvalue: " + secondValue);
        }
    }

    public void GenerateTask() // Generates values for addition tasks
    {
        switch (levelIndex)
        {
            case 1:
                // Function values in level 1
                firstValue = Random.Range(1, 5);
                secondValue = Random.Range(1, 5);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                // Correct answer
                finalValue = firstValue + secondValue;

                ChooseObject();

                // First Alterntive
                tempValue = Random.Range(1, 10);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(1, 10);
                }
                Alternative1 = tempValue;

                // Second Alternative
                tempValue = Random.Range(0, 10);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(0, 10);
                }
                Alternative2 = tempValue;
                break;

            case 2:
                // Function values in level 2
                firstValue = Random.Range(5, 10);
                secondValue = Random.Range(5, 10);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                // Correct answer
                finalValue = firstValue + secondValue;
                ChooseObject();

                // First Alterntive
                tempValue = Random.Range(10, 20);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(10, 20);
                }
                Alternative1 = tempValue;

                // Second Alternative
                tempValue = Random.Range(10, 20);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(10, 20);
                }
                Alternative2 = tempValue;
                break;

            case 3:
                // Function values in level 3
                firstValue = Random.Range(10, 15);
                secondValue = Random.Range(1, 15);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                // Correct answer
                finalValue = firstValue + secondValue;
                ChooseObject();

                // First Alterntive
                tempValue = Random.Range(10, 30);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(10, 30);
                }
                Alternative1 = tempValue;

                // Second Alternative
                tempValue = Random.Range(10, 40);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(10, 40);
                }
                Alternative2 = tempValue;
                break;

            case 4:
                // Function values in level 4
                firstValue = Random.Range(10, 20);
                secondValue = Random.Range(10, 20);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                // Correct answer
                finalValue = firstValue + secondValue;
                ChooseObject();

                // First Alterntive
                tempValue = Random.Range(10, 50);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(10, 50);
                }
                Alternative1 = tempValue;
                // Second Alternative
                tempValue = Random.Range(10, 50);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(10, 50);
                }
                Alternative2 = tempValue;
                break;

            case 5:
                // Function values in level 5
                firstValue = Random.Range(25, 50);
                secondValue = Random.Range(25, 50);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                // Correct answer
                finalValue = firstValue + secondValue;
                ChooseObject();

                // First Alterntive
                tempValue = Random.Range(30, 100);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(30, 100);
                }
                Alternative1 = tempValue;
                // Second Alternative
                tempValue = Random.Range(30, 100);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(30, 100);
                }
                Alternative2 = tempValue;
                break;

            case 6:
                // Function values in level 6
                firstValue = Random.Range(50, 100);
                secondValue = Random.Range(50, 100);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                // Correct answer
                finalValue = firstValue + secondValue;
                ChooseObject();

                // First Alterntive
                tempValue = Random.Range(100, 200);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(100, 200);
                }
                Alternative1 = tempValue;
                // Second Alternative
                tempValue = Random.Range(100, 200);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(100, 200);
                }
                Alternative2 = tempValue;
                break;

            case 7:
                // Function values in level 7
                firstValue = Random.Range(100, 250);
                secondValue = Random.Range(100, 250);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                // Correct answer
                finalValue = firstValue + secondValue;
                ChooseObject();

                // First Alterntive
                tempValue = Random.Range(100, 1000);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(100, 1000);
                }
                Alternative1 = tempValue;
                // Second Alternative
                tempValue = Random.Range(100, 1000);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(100, 1000);
                }
                Alternative2 = tempValue;
                break;

            case 8:
                // Function values in level 8
                firstValue = Random.Range(250, 500);
                secondValue = Random.Range(250, 500);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                // Correct answer
                finalValue = firstValue + secondValue;
                ChooseObject();

                // First Alterntive
                tempValue = Random.Range(250, 1100);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(250, 1000);
                }
                Alternative1 = tempValue;
                // Second Alternative
                tempValue = Random.Range(250, 1000);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(250, 1000);
                }
                Alternative2 = tempValue;
                break;

            case 9:
                // Function values in level 9
                firstValue = Random.Range(1000, 5000);
                secondValue = Random.Range(1000, 5000);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                // Correct answer
                finalValue = firstValue + secondValue;
                ChooseObject();

                // First Alterntive
                tempValue = Random.Range(2000, 10000);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(2000, 10000);
                }
                Alternative1 = tempValue;
                // Second Alternative
                tempValue = Random.Range(2000, 10000);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(2000, 10000);
                }
                Alternative2 = tempValue;
                break;
        }

        Function.text = "+";

        if (firstValue - secondValue < 0)
        {
            tempValue = secondValue;
            secondValue = firstValue;
            firstValue = tempValue;
        }

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

        //Debug.Log(firstValue + Function.text + secondValue + "=" + finalValue);
    }

    public void AltOne()
    {
        if (Alt1.text == finalValue.ToString())
        {
            button1.GetComponent<Animator>().SetBool("Correct", true);
            //ONE.gameObject.SetActive(true);
            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;
            //button1.GetComponent<Image>().sprite = greenButton;

            StartCoroutine(Correct());
        }
        if (Alt1.text != finalValue.ToString())
        {
            //ONE.gameObject.SetActive(true);

            button1.interactable = false;
            WrongScore(); //-----------------------------------------------------------------------------------------------------------------T�M��
            //button1.GetComponent<Image>().sprite = redButton;
            button1.GetComponent<Animator>().SetBool("Incorrect", true);
        }
    }

    public void AltTwo()
    {

        if (Alt2.text == finalValue.ToString())
        {
            //TWO.gameObject.SetActive(true);
            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;
            //Alt2.GetComponent<Image>().sprite = greenButton;
            button2.GetComponent<Animator>().SetBool("Correct", true);
            StartCoroutine(Correct());
        }
        if (Alt2.text != finalValue.ToString())
        {
            button2.GetComponent<Animator>().SetBool("Incorrect", true);
            //TWO.gameObject.SetActive(true);
            button2.interactable = false;
            WrongScore();//-----------------------------------------------------------------------------------------------------------------T�M��
                         //Alt2.GetComponent<Image>().sprite = redButton;

        }
    }

    public void AltThree()
    {
        if (Alt3.text == finalValue.ToString())
        {
            //THREE.gameObject.SetActive(true);
            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;
            //Alt3.GetComponent<Image>().sprite = greenButton;
            button3.GetComponent<Animator>().SetBool("Correct", true);
            StartCoroutine(Correct());
        }
        if (Alt3.text != finalValue.ToString())
        {
            //THREE.gameObject.SetActive(true);
            button3.interactable = false;
            WrongScore();//-----------------------------------------------------------------------------------------------------------------T�M��
            //Alt3.GetComponent<Image>().sprite = redButton;
            button3.GetComponent<Animator>().SetBool("Incorrect", true);
        }
    }

    public void UpdateLevelButtons()
    {
        switch (worldIndex)
        {
            case 1:
                switch (levelIndex)
                {
                    case 1:
                        switch (book.appleStickerScore)
                        {
                            case 0: levelButton1.GetComponent<Image>().sprite = clearButton; break;
                            case 1: levelButton1.GetComponent<Image>().sprite = completedButton; break;
                        }
                        break;
                    case 2:
                        switch (book.basketStickerScore)
                        {
                            case 0: levelButton2.GetComponent<Image>().sprite = clearButton; break;
                            case 1: levelButton2.GetComponent<Image>().sprite = completedButton; break;
                        }
                        break;
                    case 3:
                        switch (book.pigStickerScore)
                        {
                            case 0: levelButton3.GetComponent<Image>().sprite = clearButton; break;
                            case 1: levelButton3.GetComponent<Image>().sprite = completedButton; break;
                        }
                        break;
                    default:
                        //Debug.Log("No level index set");
                        break;
                }
                break;
            case 2:
                switch (levelIndex)
                {
                    case 4:
                        switch (book.bananaStickerScore)
                        {
                            case 0: levelButton1.GetComponent<Image>().sprite = clearButton; break;
                            case 1: levelButton1.GetComponent<Image>().sprite = completedButton; break;
                        }
                        break;
                    case 5:
                        switch (book.clusterStickerScore)
                        {
                            case 0: levelButton2.GetComponent<Image>().sprite = clearButton; break;
                            case 1: levelButton2.GetComponent<Image>().sprite = completedButton; break;
                        }
                        break;
                    case 6:
                        switch (book.monkeyStickerScore)
                        {
                            case 0: levelButton3.GetComponent<Image>().sprite = clearButton; break;
                            case 1: levelButton3.GetComponent<Image>().sprite = completedButton; break;
                        }
                        break;
                    default:
                        //Debug.Log("No level index set");
                        break;
                }
                break;
            case 3:
                switch (levelIndex)
                {
                    case 7:
                        switch (book.asteroidStickerScore)
                        {
                            case 0: levelButton1.GetComponent<Image>().sprite = clearButton; break;
                            case 1: levelButton1.GetComponent<Image>().sprite = completedButton; break;
                        }
                        break;
                    case 8:
                        switch (book.blackholeStickerScore)
                        {
                            case 0: levelButton2.GetComponent<Image>().sprite = clearButton; break;
                            case 1: levelButton2.GetComponent<Image>().sprite = completedButton; break;
                        }
                        break;
                    case 9:
                        switch (book.llamaStickerScore)
                        {
                            case 0: levelButton3.GetComponent<Image>().sprite = clearButton; break;
                            case 1: levelButton3.GetComponent<Image>().sprite = completedButton; break;
                        }
                        break;
                    default:
                        //Debug.Log("No level index set");
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
                        book.UnlockApple();
                        book.OpenSpread1();
                        break;
                    case 2:
                        book.UnlockBasket();
                        book.OpenSpread1();
                        break;
                    case 3:
                        book.UnlockPig();
                        book.OpenSpread1();
                        break;
                    default:
                        //Debug.Log("No level index set");
                        break;
                }
                break;
            case 2:
                switch (levelIndex)
                {
                    case 4:
                        book.UnlockBanana();
                        book.OpenSpread2();
                        break;
                    case 5:
                        book.UnlockCluster();
                        book.OpenSpread2();
                        break;
                    case 6:
                        book.UnlockMonkey();
                        book.OpenSpread2(); 
                        break;
                    default:
                        //Debug.Log("No level index set");
                        break;
                }
                break;
            case 3:
                switch (levelIndex)
                {
                    case 7:
                        book.UnlockAsteroid();
                        book.OpenSpread3();
                        break;
                    case 8:
                        book.UnlockBlackhole();
                        book.OpenSpread3();
                        break;
                    case 9:
                        book.UnlockLlama();
                        book.OpenSpread3();
                        break;
                    default:
                        //Debug.Log("No level index set");
                        break;
                }
                break;
        }
        book.UpdateStickers();
        UpdateLevelButtons();
    }

    public void ResetTask()
    {
        button1.GetComponent<Animator>().SetBool("Correct", false);
        button2.GetComponent<Animator>().SetBool("Correct", false);
        button3.GetComponent<Animator>().SetBool("Correct", false);
        button1.GetComponent<Animator>().SetBool("Incorrect", false);
        button2.GetComponent<Animator>().SetBool("Incorrect", false);
        button3.GetComponent<Animator>().SetBool("Incorrect", false);
        if (sumScore >= 5)
        {
            UpdateStickers();
            CountStars();
            levelEnd.gameObject.SetActive(true);
            starCount.hideStarScore();
            Animal.GetComponent<Animator>().SetBool("Dance", true);
            level.gameObject.SetActive(false);
        }
        else
        {
           
            SetTaskNumber();
            taskNumber.text = task + "/5";
            ONE.gameObject.SetActive(false);
            button1.interactable = true;
            TWO.gameObject.SetActive(false);
            button2.interactable = true;
            THREE.gameObject.SetActive(false);
            button3.interactable = true;
            AnswerSpot.text = "?";
            GenerateTask();
            Animal.GetComponent<Animator>().SetBool("Happy", false);
        }
        //Debug.Log("Level Reset");
    }

    IEnumerator Correct()
    {
        Animal.GetComponent<Animator>().SetBool("Happy", true);
        Score();
        AnswerSpot.text = finalValue.ToString();
        yield return new WaitForSeconds(1f);
        ResetTask();
    }

    public void StartLevel()
    {
        ResetTask();
        GenerateTask();
        ResetScore();
        starCount.showStarScore();
    }

    private void Start()
    {
        SetWorldIndex();
        completedButton = starCount.completedButton;
        clearButton = starCount.clearButton;
        CountStars();
        UpdateLevelButtons();
        SetTaskNumber();
        taskNumber.text = task + "/5";
        AnswerSpot.text = "?";
    }
   
}
