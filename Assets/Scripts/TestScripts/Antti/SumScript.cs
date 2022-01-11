using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SumScript : MonoBehaviour
{
    int firstValue, secondValue, tempValue, finalValue, Alternative1, Alternative2;
    [SerializeField] public int sumScore = 0;
    [SerializeField] public int sumStarCount = 0;
    [SerializeField] public int sumJungleStarCount = 0;
    [SerializeField] public int sumSpaceStarCount = 0;
    [SerializeField] public int appleStickerScore = 0;
    [SerializeField] public int basketStickerScore = 0;
    [SerializeField] public int pigStickerScore = 0;
    [SerializeField] public int bananaStickerScore = 0;
    [SerializeField] public int clusterStickerScore = 0;
    [SerializeField] public int monkeyStickerScore = 0;
    [SerializeField] public int asteroidStickerScore = 0;
    [SerializeField] public int blackholeStickerScore = 0;
    [SerializeField] public int llamaStickerScore = 0;
    public int levelIndex = 0;
    public int worldIndex = 0;
    private int stick1, stick2, stick3;
    public Text FirstValue, SecondValue, Function, Alt1, Alt2, Alt3, AnswerSpot, scoreCount;
    public GameObject ONE, TWO, THREE, appleSpawn, apple;
    public GameObject stickerOne, stickerTwo, stickerThree, stickerFour, stickerFive, stickerSix, stickerSeven, stickerEight, stickerNine;
    public GameObject sumMenuButton, levelButton1, levelButton2, levelButton3;
    public Sprite oneStar, twoStar, threeStar;
    public GameObject sumStars, menuStars;
    public Button button1, button2, button3;
    public Sprite blueButton, redButton, greenButton, completedButton;
    [SerializeField] private Transform switchOff, switchOn;
    public GameObject Animal;

    public GameObject firstObjectSlot;
    public GameObject secondObjectSlot;

    //public GameObject firstTenObjectSlot;
    //public GameObject firstHundredObjectSlot;
    //public GameObject firstOverTenSlot;

    //public GameObject secondTenObjectSlot;
    //public GameObject secondHundredObjectSlot;
    //public GameObject secondOverTenSlot;

    public Sprite[] objectSprite;
    //public Sprite[] tenObjectSprite;

    public void SaveScore()
    {
        saveScore.SaveSumScore(this);

        //luo väliaikaisen listan, joka etsii hierarkiassa olevat sumScore instanssit ja käy läpi,
        //käy läpi kaikki löytämänsä instanssit ja käskee niitä hakemaan tietokannasta kaikki tallennetut arvot;
        //näin kaikissa sumScore-instansseissa näkyy kaikkien tarrojen "StickerScore" jolloin seuraava tallennus
        //ei ylikirjoita arvoja nollaksi 
        SumScript[] tempArray = GameObject.FindObjectsOfType<SumScript>();
        foreach (SumScript i in tempArray)
        {
            i.LoadScore();
        }

    }
    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/sumscore.txt";
        if (File.Exists(path))
        { 
            scoreData data = saveScore.LoadSumScore();
            sumStarCount = data.sumStarCount;
            sumJungleStarCount = data.sumJungleStarCount;
            sumSpaceStarCount = data.sumSpaceStarCount;

            appleStickerScore = data.appleStickerScore;
            basketStickerScore = data.basketStickerScore;
            pigStickerScore = data.pigStickerScore;

            bananaStickerScore = data.bananaStickerScore;
            clusterStickerScore = data.clusterStickerScore;
            monkeyStickerScore = data.monkeyStickerScore;

            asteroidStickerScore = data.asteroidStickerScore;
            blackholeStickerScore = data.blackholeStickerScore;
            llamaStickerScore = data.llamaStickerScore;
            Debug.Log("sum stickers loaded");
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
        sumScore = 0;
        scoreCount.text = sumScore.ToString();
    }
    public void CheckStickers()
    {
        if (appleStickerScore == 1)
        {
            stickerOne.gameObject.SetActive(true);
            if (worldIndex == 1)
            {
                levelButton1.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (basketStickerScore == 1)
        {
            stickerTwo.gameObject.SetActive(true);
            if (worldIndex == 1)
            {
                levelButton2.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (pigStickerScore == 1)
        {
            stickerThree.gameObject.SetActive(true);
            if (worldIndex == 1)
            {
                levelButton3.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (bananaStickerScore == 1)
        {
            stickerFour.gameObject.SetActive(true);
            if (worldIndex == 2)
            {
                levelButton1.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (clusterStickerScore == 1)
        {
            stickerFive.gameObject.SetActive(true);
            if (worldIndex == 2)
            {
                levelButton2.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (monkeyStickerScore == 1)
        {
            stickerSix.gameObject.SetActive(true);
            if (worldIndex == 2)
            {
                levelButton3.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (asteroidStickerScore == 1)
        {
            stickerSeven.gameObject.SetActive(true);
            if (worldIndex == 3)
            {
                levelButton1.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (blackholeStickerScore == 1)
        {
            stickerEight.gameObject.SetActive(true);
            if (worldIndex == 3)
            {
                levelButton2.GetComponent<Image>().sprite = completedButton;
            }
        }
        if (llamaStickerScore == 1)
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
        sumStarCount = appleStickerScore + basketStickerScore + pigStickerScore;
        sumJungleStarCount = bananaStickerScore + clusterStickerScore + monkeyStickerScore;
        sumSpaceStarCount = asteroidStickerScore + blackholeStickerScore + llamaStickerScore;
    }

    public void CheckStars()
    {
        switch (worldIndex)
        {
            case 1:
                if (sumStarCount == 1)
                {
                    sumStars.GetComponent<Image>().sprite = oneStar;
                    menuStars.GetComponent<Image>().sprite = oneStar;
                }
                if (sumStarCount == 2)
                {
                    sumStars.GetComponent<Image>().sprite = twoStar;
                    menuStars.GetComponent<Image>().sprite = twoStar;
                }
                if (sumStarCount == 3)
                {
                    sumStars.GetComponent<Image>().sprite = threeStar;
                    menuStars.GetComponent<Image>().sprite = threeStar;
                    sumMenuButton.GetComponent<Image>().sprite = completedButton;
                }
                break;
            case 2:
                if (sumJungleStarCount == 1)
                {
                    sumStars.GetComponent<Image>().sprite = oneStar;
                    menuStars.GetComponent<Image>().sprite = oneStar;
                }
                if (sumJungleStarCount == 2)
                {
                    sumStars.GetComponent<Image>().sprite = twoStar;
                    menuStars.GetComponent<Image>().sprite = twoStar;
                }
                if (sumJungleStarCount == 3)
                {
                    sumStars.GetComponent<Image>().sprite = threeStar;
                    menuStars.GetComponent<Image>().sprite = threeStar;
                    sumMenuButton.GetComponent<Image>().sprite = completedButton;
                }
                break;
            case 3:
                if (sumSpaceStarCount == 1)
                {
                    sumStars.GetComponent<Image>().sprite = oneStar;
                    menuStars.GetComponent<Image>().sprite = oneStar;
                }
                if (sumSpaceStarCount == 2)
                {
                    sumStars.GetComponent<Image>().sprite = twoStar;
                    menuStars.GetComponent<Image>().sprite = twoStar;
                }
                if (sumSpaceStarCount == 3)
                {
                    sumStars.GetComponent<Image>().sprite = threeStar;
                    menuStars.GetComponent<Image>().sprite = threeStar;
                    sumMenuButton.GetComponent<Image>().sprite = completedButton;
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
        scoreCount.text = sumScore.ToString();
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

    }

    public void ResetStickers()
    {
        sumStarCount = 0;
        sumJungleStarCount = 0;
        sumSpaceStarCount = 0;
        appleStickerScore = 0;
        basketStickerScore = 0;
        pigStickerScore = 0;
        bananaStickerScore = 0;
        clusterStickerScore = 0;
        monkeyStickerScore = 0;
        asteroidStickerScore = 0;
        blackholeStickerScore = 0;
        llamaStickerScore = 0;
        SaveScore();
    }

    public void ChooseObject()
    {
        if(worldIndex == 1)
        {
            for (int i = 0; i < objectSprite.Length; i++)
            {
                //FIRST CALCULATION OBJECT SPRITE

                //first object sprite when first value is 10 or smaller
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

                //second object sprite when first value is 10 or smaller

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
        Debug.Log("firstvalue: " + firstValue + ", secondvalue: " + secondValue);

        }
    }

    public void SumFarm()
    {
        switch (levelIndex)
        {
            case 1:
                firstValue = Random.Range(1, 5);
                secondValue = Random.Range(1, 5);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue + secondValue;

                ChooseObject();

                //First Alterntive
                tempValue = Random.Range(1, 10);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(1, 10);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(0, 10);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(0, 10);
                }
                Alternative2 = tempValue;
                break;

            case 2:
                firstValue = Random.Range(5, 10);
                secondValue = Random.Range(5, 10);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue + secondValue;
                ChooseObject();

                //First Alterntive
                tempValue = Random.Range(10, 20);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(10, 20);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(10, 20);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(10, 20);
                }
                Alternative2 = tempValue;
                break;

            case 3:
                firstValue = Random.Range(10, 15);
                secondValue = Random.Range(1, 15);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue + secondValue;
                ChooseObject();

                //First Alterntive
                tempValue = Random.Range(10, 30);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(10, 30);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(10, 40);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(10, 40);
                }
                Alternative2 = tempValue;
                break;

            case 4:
                firstValue = Random.Range(10, 20);
                secondValue = Random.Range(10, 20);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue + secondValue;
                ChooseObject();

                //First Alterntive
                tempValue = Random.Range(10, 50);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(10, 50);
                }
                Alternative1 = tempValue;
                //Second Alternative
                tempValue = Random.Range(10, 50);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(10, 50);
                }
                Alternative2 = tempValue;
                break;

            case 5:
                firstValue = Random.Range(25, 50);
                secondValue = Random.Range(25, 50);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue + secondValue;
                ChooseObject();

                //First Alterntive
                tempValue = Random.Range(30, 100);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(30, 100);
                }
                Alternative1 = tempValue;
                //Second Alternative
                tempValue = Random.Range(30, 100);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(30, 100);
                }
                Alternative2 = tempValue;
                break;

            case 6:
                firstValue = Random.Range(50, 100);
                secondValue = Random.Range(50, 100);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue + secondValue;
                ChooseObject();

                //First Alterntive
                tempValue = Random.Range(100, 200);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(100, 200);
                }
                Alternative1 = tempValue;
                //Second Alternative
                tempValue = Random.Range(100, 200);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(100, 200);
                }
                Alternative2 = tempValue;
                break;

            case 7:
                firstValue = Random.Range(100, 250);
                secondValue = Random.Range(100, 250);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue + secondValue;
                ChooseObject();

                //First Alterntive
                tempValue = Random.Range(100, 1000);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(100, 1000);
                }
                Alternative1 = tempValue;
                //Second Alternative
                tempValue = Random.Range(100, 1000);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(100, 1000);
                }
                Alternative2 = tempValue;
                break;

            case 8:
                firstValue = Random.Range(250, 500);
                secondValue = Random.Range(250, 500);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue + secondValue;
                ChooseObject();

                //First Alterntive
                tempValue = Random.Range(250, 1100);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(250, 1000);
                }
                Alternative1 = tempValue;
                //Second Alternative
                tempValue = Random.Range(250, 1000);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(250, 1000);
                }
                Alternative2 = tempValue;
                break;

            case 9:
                firstValue = Random.Range(1000, 5000);
                secondValue = Random.Range(1000, 5000);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue + secondValue;
                ChooseObject();

                //First Alterntive
                tempValue = Random.Range(2000, 10000);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(2000, 10000);
                }
                Alternative1 = tempValue;
                //Second Alternative
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
                        if (appleStickerScore < 1)
                        {
                            appleStickerScore += 1;
                            Debug.Log("Apple unlocked");
                        }
                        break;
                    case 2:
                        if (basketStickerScore < 1)
                        {
                            basketStickerScore += 1;
                            Debug.Log("Basket unlocked");
                        }
                        break;
                    case 3:
                        if (pigStickerScore < 1)
                        {
                            pigStickerScore += 1;
                            Debug.Log("Pig unlocked");
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
                        if (bananaStickerScore < 1)
                        {
                            bananaStickerScore += 1;
                            Debug.Log("Banana unlocked");
                        }
                        break;
                    case 5:
                        if (clusterStickerScore < 1)
                        {
                            clusterStickerScore += 1;
                            Debug.Log("Cluster unlocked");
                        }
                        break;
                    case 6:
                        if (monkeyStickerScore < 1)
                        {
                            monkeyStickerScore += 1;
                            Debug.Log("Monkey unlocked");
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
                        if (asteroidStickerScore < 1)
                        {
                            asteroidStickerScore += 1;
                            Debug.Log("Asteroid unlocked");
                        }
                        break;
                    case 8:
                        if (blackholeStickerScore < 1)
                        {
                            blackholeStickerScore += 1;
                            Debug.Log("Blackhole unlocked");
                        }
                        break;
                    case 9:
                        if (llamaStickerScore < 1)
                        {
                            llamaStickerScore += 1;
                            Debug.Log("Llama unlocked");
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
        if (sumScore >= 5)
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
        SumFarm();
        Animal.GetComponent<Animator>().SetBool("Happy", false);
    }

    //public void ResetJungle()
    //{
    //    {
    //        if (sumScore >= 5)
    //        {
    //            switchOn.gameObject.SetActive(true);
    //            switchOff.gameObject.SetActive(false);
    //            stickerScoreCount();
    //        }

    //        ONE.gameObject.SetActive(false);
    //        button1.interactable = true;
    //        TWO.gameObject.SetActive(false);
    //        button2.interactable = true;
    //        THREE.gameObject.SetActive(false);
    //        button3.interactable = true;
    //        AnswerSpot.text = "?";
    //        SumJungle();
    //    }
    //}
    //public void ResetSpace()
    //{
    //    {
    //        if (sumScore >= 5)
    //        {
    //            switchOn.gameObject.SetActive(true);
    //            switchOff.gameObject.SetActive(false);
    //            stickerScoreCount();
    //        }

    //        ONE.gameObject.SetActive(false);
    //        button1.interactable = true;
    //        TWO.gameObject.SetActive(false);
    //        button2.interactable = true;
    //        THREE.gameObject.SetActive(false);
    //        button3.interactable = true;
    //        AnswerSpot.text = "?";
    //        SumSpace();
    //    }
    //}

    IEnumerator Correct()
    {
        Animal.GetComponent<Animator>().SetBool("Happy", true);
        Score();
        AnswerSpot.text = finalValue.ToString();       
        scoreCount.text = sumScore.ToString();
        yield return new WaitForSeconds(1f);
        ResetV();

    }

    public void Score()
    {
        sumScore += 1;
    }
  
    //public void SumJungle()
    //{
    //    firstValue = Random.Range(1, 100);
    //    secondValue = Random.Range(1, 100);
    //    FirstValue.text = firstValue.ToString();
    //    SecondValue.text = secondValue.ToString();

    //    if (firstValue - secondValue < 0)
    //    {
    //        tempValue = secondValue;
    //        secondValue = firstValue;
    //        firstValue = tempValue;
    //    }

    //    Function.text = "+";
    //    finalValue = firstValue + secondValue;

    //    tempValue = Random.Range(30, 200);
    //    while (tempValue == finalValue)
    //    {
    //        tempValue = Random.Range(30, 200);
    //    }
    //    Alternative1 = tempValue;

    //    //Second Alternative
    //    tempValue = Random.Range(30, 200);
    //    while (tempValue == finalValue || (tempValue == Alternative1))
    //    {
    //        tempValue = Random.Range(30, 200);
    //    }
    //    Alternative2 = tempValue;

    //    tempValue = Random.Range(1, 6);
    //    if (tempValue == 1)
    //    {
    //        Alt1.text = finalValue.ToString(); Alt2.text = Alternative1.ToString(); Alt3.text = Alternative2.ToString();
    //    }
    //    if (tempValue == 2)
    //    {
    //        Alt1.text = finalValue.ToString(); Alt2.text = Alternative2.ToString(); Alt3.text = Alternative1.ToString();
    //    }
    //    if (tempValue == 3)
    //    {
    //        Alt1.text = Alternative1.ToString(); Alt2.text = finalValue.ToString(); Alt3.text = Alternative2.ToString();
    //    }
    //    if (tempValue == 4)
    //    {
    //        Alt1.text = Alternative1.ToString(); Alt2.text = Alternative2.ToString(); Alt3.text = finalValue.ToString();
    //    }
    //    if (tempValue == 5)
    //    {
    //        Alt1.text = Alternative2.ToString(); Alt2.text = finalValue.ToString(); Alt3.text = Alternative1.ToString();
    //    }
    //    if (tempValue == 6)
    //    {
    //        Alt1.text = Alternative2.ToString(); Alt2.text = Alternative1.ToString(); Alt3.text = finalValue.ToString();
    //    }





    //    Debug.Log(firstValue + "  FUNCTION  " + secondValue + "=" + finalValue);

    //}
    //public void SumSpace()
    //{
    //    firstValue = Random.Range(1, 1000);
    //    secondValue = Random.Range(1, 1000);
    //    FirstValue.text = firstValue.ToString();
    //    SecondValue.text = secondValue.ToString();

    //    if (firstValue - secondValue < 0)
    //    {
    //        tempValue = secondValue;
    //        secondValue = firstValue;
    //        firstValue = tempValue;
    //    }

    //    Function.text = "+";
    //    finalValue = firstValue + secondValue;


    //    tempValue = Random.Range(50, 1900);
    //    while (tempValue == finalValue)
    //    {
    //        tempValue = Random.Range(50, 1900);
    //    }
    //    Alternative1 = tempValue;

    //    //Second Alternative
    //    tempValue = Random.Range(50, 1900);
    //    while (tempValue == finalValue || (tempValue == Alternative1))
    //    {
    //        tempValue = Random.Range(50, 1900);
    //    }
    //    Alternative2 = tempValue;

    //    tempValue = Random.Range(1, 6);
    //    if (tempValue == 1)
    //    {
    //        Alt1.text = finalValue.ToString(); Alt2.text = Alternative1.ToString(); Alt3.text = Alternative2.ToString();
    //    }
    //    if (tempValue == 2)
    //    {
    //        Alt1.text = finalValue.ToString(); Alt2.text = Alternative2.ToString(); Alt3.text = Alternative1.ToString();
    //    }
    //    if (tempValue == 3)
    //    {
    //        Alt1.text = Alternative1.ToString(); Alt2.text = finalValue.ToString(); Alt3.text = Alternative2.ToString();
    //    }
    //    if (tempValue == 4)
    //    {
    //        Alt1.text = Alternative1.ToString(); Alt2.text = Alternative2.ToString(); Alt3.text = finalValue.ToString();
    //    }
    //    if (tempValue == 5)
    //    {
    //        Alt1.text = Alternative2.ToString(); Alt2.text = finalValue.ToString(); Alt3.text = Alternative1.ToString();
    //    }
    //    if (tempValue == 6)
    //    {
    //        Alt1.text = Alternative2.ToString(); Alt2.text = Alternative1.ToString(); Alt3.text = finalValue.ToString();
    //    }





    //    Debug.Log(firstValue + "  FUNCTION  " + secondValue + "=" + finalValue);

    //}

   public void StartFarm()
    {
        ResetV();
        SumFarm();
        ResetScore();

    }

    //public void StartJungle()
    //{
    //    ResetJungle();
    //    SumJungle();
    //    ResetScore();
    //}
    //public void StartSpace()
    //{
    //    ResetSpace();
    //    SumSpace();
    //    ResetScore();
    //}


}
