using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class MultiplyScript : MonoBehaviour
{
    int firstValue, secondValue, tempValue, finalValue, Alternative1, Alternative2;
    [SerializeField] public int multScore = 0;
    [SerializeField] public int multJungleStarCount = 0;
    [SerializeField] public int multSpaceStarCount = 0;
    [SerializeField] public int lycheeStickerScore = 0;
    [SerializeField] public int pitahayaStickerScore = 0;
    [SerializeField] public int frogStickerScore = 0;
    [SerializeField] public int flagStickerScore = 0;
    [SerializeField] public int rocketStickerScore = 0;
    [SerializeField] public int laikaStickerScore = 0;
    public int levelIndex = 0;
    public int worldIndex = 0;
    private int stick1, stick2, stick3;
    public Text FirstValue, SecondValue, Function, Alt1, Alt2, Alt3, AnswerSpot, scoreCount;
    public GameObject ONE, TWO, THREE, appleSpawn, apple, stickerOne, stickerTwo, stickerThree, stickerFour, stickerFive, stickerSix;
    public Sprite oneStar, twoStar, threeStar;
    public GameObject multStars, menuStars;
    public Button button1, button2, button3;
    public Sprite blueButton, redButton, greenButton;
    [SerializeField] private Transform switchOff, switchOn;
    public GameObject Animal;

    public void SaveScore()
    {
        saveScore.SaveMultScore(this);
        MultiplyScript[] tempArray = GameObject.FindObjectsOfType<MultiplyScript>();
        foreach (MultiplyScript i in tempArray)
        {
            i.LoadScore();
        }

    }
    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/multscore.txt";
        if (File.Exists(path))
        {
            scoreData data = saveScore.LoadMultScore();
            multJungleStarCount = data.multJungleStarCount;
            multSpaceStarCount = data.multSpaceStarCount;

            lycheeStickerScore = data.lycheeStickerScore;
            pitahayaStickerScore = data.pitahayaStickerScore;
            frogStickerScore = data.frogStickerScore;

            flagStickerScore = data.flagStickerScore;
            rocketStickerScore = data.rocketStickerScore;
            laikaStickerScore = data.laikaStickerScore;

            Debug.Log("mult stickers loaded");
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
        multScore = 0;
        scoreCount.text = multScore.ToString();
    }

    public void CheckStickers()
    {
        if (lycheeStickerScore == 1)
        {
            stickerOne.gameObject.SetActive(true);
        }
        if (pitahayaStickerScore == 1)
        {
            stickerTwo.gameObject.SetActive(true);
        }
        if (frogStickerScore == 1)
        {
            stickerThree.gameObject.SetActive(true);
        }
        if (flagStickerScore == 1)
        {
            stickerFour.gameObject.SetActive(true);
        }
        if (rocketStickerScore == 1)
        {
            stickerFive.gameObject.SetActive(true);
        }
        if (laikaStickerScore == 1)
        {
            stickerSix.gameObject.SetActive(true);
        }
    }

    public void StarCount()
    {
        multJungleStarCount = lycheeStickerScore + pitahayaStickerScore + frogStickerScore;
        multSpaceStarCount = flagStickerScore + rocketStickerScore + laikaStickerScore;
    }

    public void CheckStars()
    {
        switch (worldIndex)
        {
            case 2:
                if (multJungleStarCount == 1)
                {
                    multStars.GetComponent<Image>().sprite = oneStar;
                    menuStars.GetComponent<Image>().sprite = oneStar;
                }
                if (multJungleStarCount == 2)
                {
                    multStars.GetComponent<Image>().sprite = twoStar;
                    menuStars.GetComponent<Image>().sprite = twoStar;
                }
                if (multJungleStarCount == 3)
                {
                    multStars.GetComponent<Image>().sprite = threeStar;
                    menuStars.GetComponent<Image>().sprite = threeStar;
                }
                break;
            case 3:
                if (multSpaceStarCount == 1)
                {
                    multStars.GetComponent<Image>().sprite = oneStar;
                    menuStars.GetComponent<Image>().sprite = oneStar;
                }
                if (multSpaceStarCount == 2)
                {
                    multStars.GetComponent<Image>().sprite = twoStar;
                    menuStars.GetComponent<Image>().sprite = twoStar;
                }
                if (multSpaceStarCount == 3)
                {
                    multStars.GetComponent<Image>().sprite = threeStar;
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
        scoreCount.text = multScore.ToString();
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
        lycheeStickerScore = 0;
        pitahayaStickerScore = 0;
        frogStickerScore = 0;
        flagStickerScore = 0;
        rocketStickerScore = 0;
        laikaStickerScore = 0;
        SaveScore();
    }

    public void MultJungle()
    {
        switch (levelIndex)
        {
            case 1:
                firstValue = Random.Range(1, 5);
                secondValue = Random.Range(0, 5);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue * secondValue;

                //First Alternative
                tempValue = Random.Range(0, 25);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(0, 25);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(0, 25);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(0, 25);
                }
                Alternative2 = tempValue;
                break;

            case 2:
                firstValue = Random.Range(0, 5);
                secondValue = Random.Range(5, 10);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue * secondValue;

                //First Alternative
                tempValue = Random.Range(0, 50);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(0, 50);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(0, 50);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(0, 50);
                }
                Alternative2 = tempValue;
                break;

            case 3:
                firstValue = Random.Range(5, 10);
                secondValue = Random.Range(5, 10);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue * secondValue;

                //First Alternative
                tempValue = Random.Range(50, 100);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(50, 100);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(50, 100);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(50, 100);
                }
                Alternative2 = tempValue;
                break;

            case 4:
                firstValue = Random.Range(1, 100);
                secondValue = Random.Range(10, 10);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue * secondValue;

                //First Alternative
                tempValue = Random.Range(10, 1000);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(10, 1000);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(10, 1000);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(10, 1000);
                }
                Alternative2 = tempValue;
                break;

            case 5:
                firstValue = Random.Range(0, 10);
                secondValue = Random.Range(1, 20);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue * secondValue;

                //First Alternative
                tempValue = Random.Range(0, 200);
                while (tempValue == finalValue)
                {
                    tempValue = Random.Range(0, 200);
                }
                Alternative1 = tempValue;

                //Second Alternative
                tempValue = Random.Range(0, 200);
                while (tempValue == finalValue || (tempValue == Alternative1))
                {
                    tempValue = Random.Range(0, 200);
                }
                Alternative2 = tempValue;
                break;

            case 6:
                firstValue = Random.Range(5, 100);
                secondValue = Random.Range(0, 10);
                FirstValue.text = firstValue.ToString();
                SecondValue.text = secondValue.ToString();

                finalValue = firstValue * secondValue;

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
        }

        if (firstValue - secondValue < 0)
        {
            tempValue = secondValue;
            secondValue = firstValue;
            firstValue = tempValue;
        }

        Function.text = "×";

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

   

    public void ResetJungle()
    {
        {
            if (multScore >= 5)
            {
                switchOn.gameObject.SetActive(true);
                Animal.GetComponent<Animator>().SetBool("Dance", true);
                switchOff.gameObject.SetActive(false);
                switch (levelIndex)
                {
                    case 1:
                        if (lycheeStickerScore < 1)
                        {
                            lycheeStickerScore += 1;
                            Debug.Log("Apple unlocked");
                        }
                        break;
                    case 2:
                        if (pitahayaStickerScore < 1)
                        {
                            pitahayaStickerScore += 1;
                            Debug.Log("Basket unlocked");
                        }
                        break;
                    case 3:
                        if (frogStickerScore < 1)
                        {
                            frogStickerScore += 1;
                            Debug.Log("Pig unlocked");
                        }
                        break;
                    default:
                        Debug.Log("No level index set");
                        break;
                }

            }

            ONE.gameObject.SetActive(false);
            button1.interactable = true;
            TWO.gameObject.SetActive(false);
            button2.interactable = true;
            THREE.gameObject.SetActive(false);
            button3.interactable = true;
            AnswerSpot.text = "?";
            MultJungle();
            Animal.GetComponent<Animator>().SetBool("Happy", false);
        }
    }
    public void ResetSpace()
    {
        {
            if (multScore >= 5)
            {
                switchOn.gameObject.SetActive(true);
                switchOff.gameObject.SetActive(false);
                switch (levelIndex)
                {
                    case 1:
                        if (lycheeStickerScore < 1)
                        {
                            lycheeStickerScore += 1;
                            Debug.Log("Apple unlocked");
                        }
                        break;
                    case 2:
                        if (pitahayaStickerScore < 1)
                        {
                            pitahayaStickerScore += 1;
                            Debug.Log("Basket unlocked");
                        }
                        break;
                    case 3:
                        if (frogStickerScore < 1)
                        {
                            frogStickerScore += 1;
                            Debug.Log("Pig unlocked");
                        }
                        break;
                    default:
                        Debug.Log("No level index set");
                        break;
                }

            }

            ONE.gameObject.SetActive(false);
            button1.interactable = true;
            TWO.gameObject.SetActive(false);
            button2.interactable = true;
            THREE.gameObject.SetActive(false);
            button3.interactable = true;
            AnswerSpot.text = "?";
            MultSpace();
        }
    }

    IEnumerator Correct()
    {
        Score();
        AnswerSpot.text = finalValue.ToString();
        scoreCount.text = multScore.ToString();
        yield return new WaitForSeconds(1f);
        ResetJungle();
    }

    public void Score()
    {
        multScore += 1;
    }


    
        public void MultSpace()
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
            finalValue = firstValue + secondValue;

            tempValue = Random.Range(30, 200);
            while (tempValue == finalValue)
            {
                tempValue = Random.Range(30, 200);
            }
            Alternative1 = tempValue;

            //Second Alternative
            tempValue = Random.Range(30, 200);
            while (tempValue == finalValue || (tempValue == Alternative1))
            {
                tempValue = Random.Range(30, 200);
            }
            Alternative2 = tempValue;

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


        public void StartJungle()
    {
        ResetJungle();
        MultJungle();
        ResetScore();
    }
    public void StartSpace()
    {
        ResetSpace();
        MultSpace();
        ResetScore();
    }


}

