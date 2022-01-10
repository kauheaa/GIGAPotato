using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SubScript : MonoBehaviour
{
    int firstValue, secondValue, thirdValue, fourthValue, tempValue, finalValue, Alternative1, Alternative2;
    //[SerializeField] public int sumScore = 0;
    //[SerializeField] public int divScore = 0;
    //[SerializeField] public int multScore = 0;
    [SerializeField] public int subScore = 0;
    [SerializeField] public int subStarCount = 0;
    [SerializeField] public int subJungleStarCount = 0;
    [SerializeField] public int subSpaceStarCount = 0;
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
    public Sprite oneStar, twoStar, threeStar;
    public GameObject subStars, menuStars;
    public Button button1, button2, button3;
    public Sprite blueButton, redButton, greenButton;
    public GameObject Animal;

    public GameObject firstObjectSlot;
    public GameObject secondObjectSlot;
    public GameObject firstTenObjectSlot;
    public GameObject firstOverTenSlot;
    public GameObject secondTenObjectSlot;
    public GameObject secondOverTenSlot;

    public Sprite[] objectSprite;
    public Sprite[] tenObjectSprite;


    public void SaveScore()
    {
        saveScore.SaveSubScore(this);
        SubScript[] tempArray = GameObject.FindObjectsOfType<SubScript>();
        foreach (SubScript i in tempArray)
        {
            i.LoadScore();
        }

    }
    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/subscore.txt";
        if (File.Exists(path))
        {
            scoreData data = saveScore.LoadSubScore();
            subStarCount = data.subStarCount;
            subJungleStarCount = data.subJungleStarCount;
            subSpaceStarCount = data.subSpaceStarCount;

            carrotStickerScore = data.carrotStickerScore;
            bucketStickerScore = data.bucketStickerScore;
            bunnyStickerScore = data.bunnyStickerScore;

            coconutStickerScore = data.coconutStickerScore;
            ocularsStickerScore = data.ocularsStickerScore;
            slothStickerScore = data.slothStickerScore;

            starStickerScore = data.starStickerScore;
            planetStickerScore = data.planetStickerScore;
            cowStickerScore = data.cowStickerScore;
            Debug.Log("sub stickers loaded");
        }
        else
        {
            SaveScore();
        }

    }

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
        }
        if (bucketStickerScore == 1)
        {
            stickerTwo.gameObject.SetActive(true);
        }
        if (bunnyStickerScore == 1)
        {
            stickerThree.gameObject.SetActive(true);
        }
        if (coconutStickerScore == 1)
        {
            stickerFour.gameObject.SetActive(true);
        }
        if (ocularsStickerScore == 1)
        {
            stickerFive.gameObject.SetActive(true);
        }
        if (slothStickerScore == 1)
        {
            stickerSix.gameObject.SetActive(true);
        }
        //if (starStickerScore == 1)
        //{
        //    stickerSeven.gameObject.SetActive(true);
        //}
        //if (planetStickerScore == 1)
        //{
        //    stickerEight.gameObject.SetActive(true);
        //}
        //if (cowStickerScore == 1)
        //{
        //    stickerNine.gameObject.SetActive(true);
        //}
    }
    public void StarCount()
    {
        subStarCount = carrotStickerScore + bucketStickerScore + bunnyStickerScore;
        subJungleStarCount = coconutStickerScore + ocularsStickerScore + slothStickerScore;
        subSpaceStarCount = starStickerScore + planetStickerScore + cowStickerScore;
    }

    public void CheckStars()
    {
        switch (worldIndex)
        {
            case 1:
                if (subStarCount == 1)
                {
                    subStars.GetComponent<Image>().sprite = oneStar;
                    menuStars.GetComponent<Image>().sprite = oneStar;
                }
                if (subStarCount == 2)
                {
                    subStars.GetComponent<Image>().sprite = twoStar;
                    menuStars.GetComponent<Image>().sprite = twoStar;
                }
                if (subStarCount == 3)
                {
                    subStars.GetComponent<Image>().sprite = threeStar;
                    menuStars.GetComponent<Image>().sprite = threeStar;
                }
                break;
            case 2:
                if (subJungleStarCount == 1)
                {
                    subStars.GetComponent<Image>().sprite = oneStar;
                    menuStars.GetComponent<Image>().sprite = oneStar;
                }
                if (subJungleStarCount == 2)
                {
                    subStars.GetComponent<Image>().sprite = twoStar;
                    menuStars.GetComponent<Image>().sprite = twoStar;
                }
                if (subJungleStarCount == 3)
                {
                    subStars.GetComponent<Image>().sprite = threeStar;
                    menuStars.GetComponent<Image>().sprite = threeStar;
                }
                break;
            case 3:
                if (subSpaceStarCount == 1)
                {
                    subStars.GetComponent<Image>().sprite = oneStar;
                    menuStars.GetComponent<Image>().sprite = oneStar;
                }
                if (subSpaceStarCount == 2)
                {
                    subStars.GetComponent<Image>().sprite = twoStar;
                    menuStars.GetComponent<Image>().sprite = twoStar;
                }
                if (subSpaceStarCount == 3)
                {
                    subStars.GetComponent<Image>().sprite = threeStar;
                    menuStars.GetComponent<Image>().sprite = threeStar;
                }
                break;
            default:
                Debug.Log("No level index set");
                break;
        }
    }

    private void Start()
    {
        LoadScore();
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
        SaveScore();
    }
    // Update is called once per frame
    void Update()
    {
        //   score = int.Parse(scoreCount.text);
    }

    public void ResetStickers()
    {
        subStarCount = 0;
        subJungleStarCount = 0;
        subSpaceStarCount = 0;
        carrotStickerScore = 0;
        bucketStickerScore = 0;
        bunnyStickerScore = 0;
        coconutStickerScore = 0;
        ocularsStickerScore = 0;
        slothStickerScore = 0;
        starStickerScore = 0;
        planetStickerScore = 0;
        cowStickerScore = 0;
        SaveScore();
    }

    public void ChooseObject()
    {
        for (int i = 0; i < objectSprite.Length; i++)
        {
            //FIRST CALCULATION OBJECT SPRITE

            //first object sprite when first value is 10 or smaller
            if (firstValue <= 10)
            {
                firstObjectSlot.gameObject.SetActive(true);
                firstTenObjectSlot.gameObject.SetActive(false);
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
                }
            }
            //deactivates first sprite and activates tens and over tens sprite when first value is bigger than 10
            if (firstValue >= 10 && firstValue / 10 >= 1)
            {
                if (worldIndex >= 2)
                {
                    firstObjectSlot.gameObject.SetActive(false);
                    firstTenObjectSlot.gameObject.SetActive(true);
                    firstOverTenSlot.gameObject.SetActive(true);
                }
                else
                {
                    firstObjectSlot.gameObject.SetActive(true);
                    firstTenObjectSlot.gameObject.SetActive(false);
                    switch (firstValue)
                    {
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
                }

                // first sprite presenting tens
                switch (firstValue / 10)
                {
                    case 1:
                        firstTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[0];
                        break;

                    case 2:
                        firstTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[1];
                        break;

                    case 3:
                        firstTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[2];
                        break;

                    case 4:
                        firstTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[3];
                        break;

                    case 5:
                        firstTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[4];
                        break;

                    case 6:
                        firstTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[5];
                        break;

                    case 7:
                        firstTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[6];
                        break;

                    case 8:
                        firstTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[7];
                        break;

                    case 9:
                        firstTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[8];
                        break;
                }
                // first sprite presenting numbers over then but less than next ten
                switch (firstValue % 10)
                {
                    case 0:
                        firstOverTenSlot.gameObject.SetActive(false);
                        break;
                    case 1:
                        firstOverTenSlot.GetComponent<Image>().sprite = objectSprite[1];
                        break;
                    case 2:
                        firstOverTenSlot.GetComponent<Image>().sprite = objectSprite[2];
                        break;
                    case 3:
                        firstOverTenSlot.GetComponent<Image>().sprite = objectSprite[3];
                        break;
                    case 4:
                        firstOverTenSlot.GetComponent<Image>().sprite = objectSprite[4];
                        break;
                    case 5:
                        firstOverTenSlot.GetComponent<Image>().sprite = objectSprite[5];
                        break;
                    case 6:
                        firstOverTenSlot.GetComponent<Image>().sprite = objectSprite[6];
                        break;
                    case 7:
                        firstOverTenSlot.GetComponent<Image>().sprite = objectSprite[7];
                        break;
                    case 8:
                        firstOverTenSlot.GetComponent<Image>().sprite = objectSprite[8];
                        break;
                    case 9:
                        firstOverTenSlot.GetComponent<Image>().sprite = objectSprite[9];
                        break;
                    case 10:
                        firstOverTenSlot.GetComponent<Image>().sprite = objectSprite[10];
                        break;
                }
            }
            //SECOND OBJECT SPRITE

            //second object sprite when first value is 10 or smaller
            if (secondValue <= 10)
            {
                secondObjectSlot.gameObject.SetActive(true);
                secondObjectSlot.GetComponent<Image>().color = new Color(0,0,0,.5f);
                secondTenObjectSlot.gameObject.SetActive(false);

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
                }
            }
            //deactivates second sprite and activates tens and over tens sprite when second value is bigger than 10
            if (secondValue >= 10 && secondValue / 10 >= 1)
            {
                if (worldIndex >= 2)
                {
                    secondObjectSlot.gameObject.SetActive(false);
                    secondTenObjectSlot.gameObject.SetActive(true);
                    secondOverTenSlot.gameObject.SetActive(true);
                }
                else
                {
                    secondObjectSlot.gameObject.SetActive(true);
                    secondTenObjectSlot.gameObject.SetActive(false);
                    switch (secondValue)
                    {
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

                // second sprite presenting tens
                switch (secondValue / 10)
                {
                    case 1:
                        secondTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[0];
                        break;

                    case 2:
                        secondTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[1];
                        break;

                    case 3:
                        secondTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[2];
                        break;

                    case 4:
                        secondTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[3];
                        break;

                    case 5:
                        secondTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[4];
                        break;

                    case 6:
                        secondTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[5];
                        break;

                    case 7:
                        secondTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[6];
                        break;

                    case 8:
                        secondTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[7];
                        break;

                    case 9:
                        secondTenObjectSlot.GetComponent<Image>().sprite = tenObjectSprite[8];
                        break;
                }
                // second sprite presenting numbers over then but less than next ten
                switch (secondValue % 10)
                {
                    case 0:
                        secondOverTenSlot.gameObject.SetActive(false);
                        break;
                    case 1:
                        secondOverTenSlot.GetComponent<Image>().sprite = objectSprite[1];
                        break;
                    case 2:
                        secondOverTenSlot.GetComponent<Image>().sprite = objectSprite[2];
                        break;
                    case 3:
                        secondOverTenSlot.GetComponent<Image>().sprite = objectSprite[3];
                        break;
                    case 4:
                        secondOverTenSlot.GetComponent<Image>().sprite = objectSprite[4];
                        break;
                    case 5:
                        secondOverTenSlot.GetComponent<Image>().sprite = objectSprite[5];
                        break;
                    case 6:
                        secondOverTenSlot.GetComponent<Image>().sprite = objectSprite[6];
                        break;
                    case 7:
                        secondOverTenSlot.GetComponent<Image>().sprite = objectSprite[7];
                        break;
                    case 8:
                        secondOverTenSlot.GetComponent<Image>().sprite = objectSprite[8];
                        break;
                    case 9:
                        secondOverTenSlot.GetComponent<Image>().sprite = objectSprite[9];
                        break;
                    case 10:
                        secondOverTenSlot.GetComponent<Image>().sprite = objectSprite[10];
                        break;
                }
            }
        }
        Debug.Log("firstvalue: " + firstValue + ", secondvalue: " + secondValue);
    }
    public void SubFarm()
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

            case 6:
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

            case 7:
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

            case 8:
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

            case 9:
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

    public void ResetV()
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
        SubFarm();
        Animal.GetComponent<Animator>().SetBool("Happy", false);
    }

    IEnumerator Correct()
    {
        Score();
        AnswerSpot.text = finalValue.ToString();
        scoreCount.text = subScore.ToString();
        Animal.GetComponent<Animator>().SetBool("Happy", true);
        yield return new WaitForSeconds(1f);
        ResetV();




    }
    public void Score()
    {
        subScore += 1;
    }

    public void SubJungle()
    {
        firstValue = Random.Range(1, 100);
        secondValue = Random.Range(1, 100);
        FirstValue.text = firstValue.ToString();
        SecondValue.text = secondValue.ToString();

        if (firstValue - secondValue < 0)
        {
            tempValue = secondValue;
            secondValue = firstValue;
            firstValue = tempValue;
        }

        Function.text = "+";
        finalValue = firstValue - secondValue;

    }
    public void SubSpace()
    {
        firstValue = Random.Range(1, 1000);
        secondValue = Random.Range(1, 1000);
        FirstValue.text = firstValue.ToString();
        SecondValue.text = secondValue.ToString();

        if (firstValue - secondValue < 0)
        {
            tempValue = secondValue;
            secondValue = firstValue;
            firstValue = tempValue;
        }

        Function.text = "+";
        finalValue = firstValue - secondValue;

    }

    public void StartFarm()
    {
        ResetV();
        SubFarm();
        ResetScore();

    }
    public void StartJungle()
    {
        ResetV();
        SubJungle();
    }
    public void StartSpace()
    {
        ResetV();
        SubSpace();
    }


}