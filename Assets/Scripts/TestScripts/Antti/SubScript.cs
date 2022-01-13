using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SubScript : MonoBehaviour
{
    public StickerBook book;
    int firstValue, secondValue, thirdValue, fourthValue, tempValue, finalValue, Alternative1, Alternative2;
    //[SerializeField] public int sumScore = 0;
    //[SerializeField] public int divScore = 0;
    //[SerializeField] public int multScore = 0;
    [SerializeField] public int subScore = 0;
    [SerializeField] public int farmStarCount = 0;
    [SerializeField] public int jungleStarCount = 0;
    [SerializeField] public int spaceStarCount = 0;
    [SerializeField] public int carrotStickerScore = 0;
    [SerializeField] public int bucketStickerScore = 0;
    [SerializeField] public int bunnyStickerScore = 0;
    [SerializeField] public int coconutStickerScore = 0;
    [SerializeField] public int ocularsStickerScore = 0;
    [SerializeField] public int slothStickerScore = 0;
    [SerializeField] public int starStickerScore = 0;
    [SerializeField] public int planetStickerScore = 0;
    [SerializeField] public int cowStickerScore = 0;
    public int levelIndex = 0;
    public int worldIndex = 0;
    [SerializeField] private Transform switchOff, switchOn;
    public Text FirstValue, SecondValue, Function, Alt1, Alt2, Alt3, AnswerSpot, scoreCount;
    public GameObject ONE, TWO, THREE, appleSpawn, apple;
    public GameObject stickerOne, stickerTwo, stickerThree, stickerFour, stickerFive, stickerSix, stickerSeven, stickerEight, stickerNine;
    public GameObject subMenuButton, levelButton1, levelButton2, levelButton3;
    public Sprite oneStar, twoStar, threeStar;
    public GameObject subStars, menuStars;
    public Button button1, button2, button3;
    public Sprite blueButton, redButton, greenButton, completedButton;
    public GameObject Animal;

    public GameObject firstObjectSlot;
    public GameObject secondObjectSlot;
    //public GameObject firstTenObjectSlot;
    //public GameObject firstOverTenSlot;
    //public GameObject secondTenObjectSlot;
    //public GameObject secondOverTenSlot;

    public Sprite[] objectSprite;
    //public Sprite[] tenObjectSprite;


    //public void saveScore()
    //{
    //    saveScore.SaveSubScore(this);
    //    SubScript[] tempArray = GameObject.FindObjectsOfType<SubScript>();
    //    foreach (SubScript i in tempArray)
    //    {
    //        i.LoadScore();
    //    }

    //}
    //public void LoadScore()
    //{
    //    string path = Application.persistentDataPath + "/subscore.txt";
    //    if (File.Exists(path))
    //    {
    //        scoreData data = saveScore.LoadSubScore();
    //        subStarCount = data.subStarCount;
    //        subJungleStarCount = data.subJungleStarCount;
    //        subSpaceStarCount = data.subSpaceStarCount;

    //        carrotStickerScore = data.carrotStickerScore;
    //        bucketStickerScore = data.bucketStickerScore;
    //        bunnyStickerScore = data.bunnyStickerScore;

    //        coconutStickerScore = data.coconutStickerScore;
    //        ocularsStickerScore = data.ocularsStickerScore;
    //        slothStickerScore = data.slothStickerScore;

    //        starStickerScore = data.starStickerScore;
    //        planetStickerScore = data.planetStickerScore;
    //        cowStickerScore = data.cowStickerScore;
    //        Debug.Log("sub stickers loaded");
    //    }
    //    else
    //    {
    //        saveScore();
    //    }

    //}

    public void SetLevelIndex(int index)
    {
        levelIndex = index;
    }
    public void SetWorld(int world)
    {
        worldIndex = world;
    }

    public void ResetScore()
    {
        subScore = 0;
        scoreCount.text = subScore.ToString();
    }

    public void CheckStickers()
    {
        if (carrotStickerScore == 1)
        {
            stickerOne.gameObject.SetActive(true);
            if (worldIndex == 1)
            {
                levelButton1.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (bucketStickerScore == 1)
        {
            stickerTwo.gameObject.SetActive(true);
            if (worldIndex == 1)
            {
                levelButton2.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (bunnyStickerScore == 1)
        {
            stickerThree.gameObject.SetActive(true);
            if (worldIndex == 1)
            {
                levelButton3.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (coconutStickerScore == 1)
        {
            stickerFour.gameObject.SetActive(true);
            if (worldIndex == 2)
            {
                levelButton1.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (ocularsStickerScore == 1)
        {
            stickerFive.gameObject.SetActive(true);
            if (worldIndex == 2)
            {
                levelButton2.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (slothStickerScore == 1)
        {
            stickerSix.gameObject.SetActive(true);
            if (worldIndex == 2)
            {
                levelButton3.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (starStickerScore == 1)
        {
            stickerSeven.gameObject.SetActive(true);
            if (worldIndex == 3)
            {
                levelButton1.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (planetStickerScore == 1)
        {
            stickerEight.gameObject.SetActive(true);
            if (worldIndex == 3)
            {
                levelButton2.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (cowStickerScore == 1)
        {
            stickerNine.gameObject.SetActive(true);
            if (worldIndex == 3)
            {
                levelButton3.GetComponent<Image>().sprite = completedButton;
            }
        }
    }
    public void StarCount()
    {
        farmStarCount = book.subFarmStarCount;
        jungleStarCount = book.subJungleStarCount;
        spaceStarCount = book.subSpaceStarCount;
    }

    public void CheckStars()
    {
        switch (worldIndex)
        {
            case 1:
                if (farmStarCount == 1)
                {
                    subStars.GetComponent<Image>().sprite = oneStar;
                    menuStars.GetComponent<Image>().sprite = oneStar;
                }
                if (farmStarCount == 2)
                {
                    subStars.GetComponent<Image>().sprite = twoStar;
                    menuStars.GetComponent<Image>().sprite = twoStar;
                }
                if (farmStarCount == 3)
                {
                    subStars.GetComponent<Image>().sprite = threeStar;
                    menuStars.GetComponent<Image>().sprite = threeStar;
                    subMenuButton.GetComponent<Image>().sprite = completedButton;
                }
                break;
            case 2:
                if (jungleStarCount == 1)
                {
                    subStars.GetComponent<Image>().sprite = oneStar;
                    menuStars.GetComponent<Image>().sprite = oneStar;
                }
                if (jungleStarCount == 2)
                {
                    subStars.GetComponent<Image>().sprite = twoStar;
                    menuStars.GetComponent<Image>().sprite = twoStar;
                }
                if (jungleStarCount == 3)
                {
                    subStars.GetComponent<Image>().sprite = threeStar;
                    menuStars.GetComponent<Image>().sprite = threeStar;
                    subMenuButton.GetComponent<Image>().sprite = completedButton;
                }
                break;
            case 3:
                if (spaceStarCount == 1)
                {
                    subStars.GetComponent<Image>().sprite = oneStar;
                    menuStars.GetComponent<Image>().sprite = oneStar;
                }
                if (spaceStarCount == 2)
                {
                    subStars.GetComponent<Image>().sprite = twoStar;
                    menuStars.GetComponent<Image>().sprite = twoStar;
                }
                if (spaceStarCount == 3)
                {
                    subStars.GetComponent<Image>().sprite = threeStar;
                    menuStars.GetComponent<Image>().sprite = threeStar;
                    subMenuButton.GetComponent<Image>().sprite = completedButton;
                }
                break;
            default:
                Debug.Log("No level index set");
                break;
        }
    }

    private void Start()
    {
        //LoadScore();
        CheckStickers();
        StarCount();
        CheckStars();
        AnswerSpot.text = "?";
    }

    public void UpdateStickers()
    {
        CheckStickers();
        StarCount();
        CheckStars();
        //saveScore();
    }
    // Update is called once per frame
    void Update()
    {
        //   score = int.Parse(scoreCount.text);
    }

    public void ChooseObject()
    {
        if (worldIndex == 1)
        {
            secondObjectSlot.GetComponent<Image>().color = new Color(0, 0, 0, .5f);
            for (int i = 0; i < objectSprite.Length; i++)
            {
                //FIRST CALCULATION OBJECT SPRITE

                switch (firstValue)
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

                switch (secondValue)
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
        }
        Debug.Log("firstvalue: " + firstValue + ", secondvalue: " + secondValue);
    }
    public void GenerateTask()
    {
        switch (levelIndex)
        {
            case 1:
                firstValue = Random.Range(0, 5);
                secondValue = Random.Range(0, 5);
                thirdValue = firstValue;
                fourthValue = secondValue;

                if (firstValue < secondValue)
                {
                    firstValue = fourthValue;
                    secondValue = thirdValue;
                }

                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();
                finalValue = firstValue - secondValue;

                ChooseObject();

                //First Alternative
                tempValue = Random.Range(0, 5);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(0, 5);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(1, 5);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(1, 5);
                }
                Alternative2 = tempValue;
                break;

            case 2:
                firstValue = Random.Range(0, 10);
                secondValue = Random.Range(0, 10);
                thirdValue = firstValue;
                fourthValue = secondValue;

                if (firstValue < secondValue)
                {
                    firstValue = fourthValue;
                    secondValue = thirdValue;
                }

                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();
                finalValue = firstValue - secondValue;

                ChooseObject();

                //First Alternative
                tempValue = Random.Range(0, 10);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(0, 10);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(1, 10);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(1, 10);
                }
                Alternative2 = tempValue;
                break;

            case 3:
                firstValue = Random.Range(0, 15);
                secondValue = Random.Range(0, 15);
                thirdValue = firstValue;
                fourthValue = secondValue;

                if (firstValue < secondValue)
                {
                    firstValue = fourthValue;
                    secondValue = thirdValue;
                }

                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();
                finalValue = firstValue - secondValue;

                ChooseObject();

                //First Alternative
                tempValue = Random.Range(0, 15);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(0, 15);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(1, 15);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(1, 15);
                }
                Alternative2 = tempValue;
                break;

            case 4:
                firstValue = Random.Range(10, 20);
                secondValue = Random.Range(1, 15);
                thirdValue = firstValue;
                fourthValue = secondValue;

                if (firstValue < secondValue)
                {
                    firstValue = fourthValue;
                    secondValue = thirdValue;
                }

                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();
                finalValue = firstValue - secondValue;

                ChooseObject();

                //First Alternative
                tempValue = Random.Range(0, 20);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(0, 20);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(1, 20);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(1, 20);
                }
                Alternative2 = tempValue;
                break;

            case 5:
                firstValue = Random.Range(10, 50);
                secondValue = Random.Range(10, 50);
                thirdValue = firstValue;
                fourthValue = secondValue;

                if (firstValue < secondValue)
                {
                    firstValue = fourthValue;
                    secondValue = thirdValue;
                }

                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();
                finalValue = firstValue - secondValue;

                ChooseObject();

                //First Alternative
                tempValue = Random.Range(0, 50);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(0, 50);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(1, 50);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(1, 50);
                }
                Alternative2 = tempValue;
                break;

            case 6:
                firstValue = Random.Range(10, 100);
                secondValue = Random.Range(10, 100);
                thirdValue = firstValue;
                fourthValue = secondValue;

                if (firstValue < secondValue)
                {
                    firstValue = fourthValue;
                    secondValue = thirdValue;
                }

                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();
                finalValue = firstValue - secondValue;

                ChooseObject();

                //First Alternative
                tempValue = Random.Range(0, 100);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(0, 100);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(1, 10);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(1, 10);
                }
                Alternative2 = tempValue;
                break;

            case 7:
                firstValue = Random.Range(250, 500);
                secondValue = Random.Range(100, 500);
                thirdValue = firstValue;
                fourthValue = secondValue;

                if (firstValue < secondValue)
                {
                    firstValue = fourthValue;
                    secondValue = thirdValue;
                }

                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();
                finalValue = firstValue - secondValue;

                ChooseObject();

                //First Alternative
                tempValue = Random.Range(0, 500);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(0, 500);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(0, 500);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(0, 500);
                }
                Alternative2 = tempValue;
                break;

            case 8:
                firstValue = Random.Range(500, 1000);
                secondValue = Random.Range(250, 1000);
                thirdValue = firstValue;
                fourthValue = secondValue;

                if (firstValue < secondValue)
                {
                    firstValue = fourthValue;
                    secondValue = thirdValue;
                }

                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();
                finalValue = firstValue - secondValue;

                ChooseObject();

                //First Alternative
                tempValue = Random.Range(0, 1000);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(0, 1000);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(0, 1000);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(0, 1000);
                }
                Alternative2 = tempValue;
                break;

            case 9:
                firstValue = Random.Range(1000, 10000);
                secondValue = Random.Range(1000, 10000);
                thirdValue = firstValue;
                fourthValue = secondValue;

                if (firstValue < secondValue)
                {
                    firstValue = fourthValue;
                    secondValue = thirdValue;
                }

                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();
                finalValue = firstValue - secondValue;

                ChooseObject();

                //First Alternative
                tempValue = Random.Range(0, 10000);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(0, 10000);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(0, 10000);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(0, 10000);
                }
                Alternative2 = tempValue;
                break;
        }

        if (firstValue - secondValue < 0)
        {
            tempValue = secondValue;
            secondValue = firstValue;
            firstValue = tempValue;
        }

        Function.text = "-";

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





        Debug.Log(firstValue + "  FUNCTION  " + secondValue + "=" + finalValue);
    }
    public void AltOne()
    {
        if (Alt1.text == finalValue.ToString())
        {
            ONE.gameObject.SetActive(true);
            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;
            ONE.GetComponent<Image>().sprite = greenButton;
            StartCoroutine(Correct());
        }
        if (Alt1.text != finalValue.ToString())
        {
            ONE.gameObject.SetActive(true);
            button1.interactable = false;
            ONE.GetComponent<Image>().sprite = redButton;
        }
    }

    public void AltTwo()
    {

        if (Alt2.text == finalValue.ToString())
        {
            TWO.gameObject.SetActive(true);
            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;
            TWO.GetComponent<Image>().sprite = greenButton;
            StartCoroutine(Correct());
        }
        if (Alt2.text != finalValue.ToString())
        {
            TWO.gameObject.SetActive(true);
            button2.interactable = false;
            TWO.GetComponent<Image>().sprite = redButton;
        }
    }

    public void AltThree()
    {
        if (Alt3.text == finalValue.ToString())
        {
            THREE.gameObject.SetActive(true);
            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;
            THREE.GetComponent<Image>().sprite = greenButton;
            StartCoroutine(Correct());
        }
        if (Alt3.text != finalValue.ToString())
        {
            THREE.gameObject.SetActive(true);
            button3.interactable = false;
            THREE.GetComponent<Image>().sprite = redButton;
        }
    }

    public void stickerScoreCount()
    {
        switch (worldIndex)
        {
            case 1:
                switch (levelIndex)
                {
                    case 1:
                        if (carrotStickerScore < 1)
                        {
                            carrotStickerScore += 1;
                            Debug.Log("Carrot unlocked");
                        }
                        break;
                    case 2:
                        if (bucketStickerScore < 1)
                        {
                            bucketStickerScore += 1;
                            Debug.Log("Bucket unlocked");
                        }
                        break;
                    case 3:
                        if (bunnyStickerScore < 1)
                        {
                            bunnyStickerScore += 1;
                            Debug.Log("Bunny unlocked");
                        }
                        break;
                    default:
                        Debug.Log("No level index set");
                        break;
                }
                break;
            case 2:
                switch (levelIndex)
                {
                    case 4:
                        if (coconutStickerScore < 1)
                        {
                            coconutStickerScore += 1;
                            Debug.Log("Coconut unlocked");
                        }
                        break;
                    case 5:
                        if (ocularsStickerScore < 1)
                        {
                            ocularsStickerScore += 1;
                            Debug.Log("Oculars unlocked");
                        }
                        break;
                    case 6:
                        if (slothStickerScore < 1)
                        {
                            slothStickerScore += 1;
                            Debug.Log("Sloth unlocked");
                        }
                        break;
                    default:
                        Debug.Log("No level index set");
                        break;
                }
                break;
            case 3:
                switch (levelIndex)
                {
                    case 7:
                        if (starStickerScore < 1)
                        {
                            starStickerScore += 1;
                            Debug.Log("Star sticker unlocked");
                        }
                        break;
                    case 8:
                        if (planetStickerScore < 1)
                        {
                            planetStickerScore += 1;
                            Debug.Log("Planet unlocked");
                        }
                        break;
                    case 9:
                        if (cowStickerScore < 1)
                        {
                            cowStickerScore += 1;
                            Debug.Log("Cow unlocked");
                        }
                        break;
                    default:
                        Debug.Log("No level index set");
                        break;
                }
                break;
        }
    }

    public void ResetTask()
    {
        if (subScore >= 5)
        {
            stickerScoreCount();
            switchOn.gameObject.SetActive(true);
            Animal.GetComponent<Animator>().SetBool("Dance", true);
            switchOff.gameObject.SetActive(false);
        }

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

    IEnumerator Correct()
    {
        Score();
        AnswerSpot.text = finalValue.ToString();
        scoreCount.text = subScore.ToString();
        Animal.GetComponent<Animator>().SetBool("Happy", true);
        yield return new WaitForSeconds(1f);
        ResetTask();
    }
    public void Score()
    {
        subScore += 1;
    }

    public void StartLevel()
    {
        ResetTask();
        GenerateTask();
        ResetScore();

    }
}