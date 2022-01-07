using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DivideScript : MonoBehaviour
{
    int firstValue, secondValue, thirdValue, fourthValue, tempValue, finalValue, Alternative1, Alternative2;
    [SerializeField] public int divScore = 0;
    [SerializeField] public int divJungleStarCount = 0;
    [SerializeField] public int divSpaceStarCount = 0;
    [SerializeField] public int avocadoStickerScore = 0;
    [SerializeField] public int toolStickerScore = 0;
    [SerializeField] public int tigerStickerScore = 0;
    [SerializeField] public int driedfishStickerScore = 0;
    [SerializeField] public int octopusStickerScore = 0;
    [SerializeField] public int catStickerScore = 0;
    public int levelIndex = 0;
    public int worldIndex = 0;
    private int stick1, stick2, stick3;
    public Text FirstValue, SecondValue, Function, Alt1, Alt2, Alt3, AnswerSpot, scoreCount;
    public GameObject ONE, TWO, THREE, appleSpawn, apple, stickerOne, stickerTwo, stickerThree, stickerFour, stickerFive, stickerSix;
    public Sprite oneStar, twoStar, threeStar;
    public GameObject divStars, menuStars;
    public Button button1, button2, button3;
    public Sprite blueButton, redButton, greenButton;
    [SerializeField] private Transform switchOff, switchOn;
    public GameObject Animal;




    public void SaveScore()
    {
        saveScore.SaveDivScore(this);

        //luo väliaikaisen listan, joka etsii hierarkiassa olevat divScore instanssit ja käy läpi,
        //käy läpi kaikki löytämänsä instanssit ja käskee niitä hakemaan tietokannasta kaikki tallennetut arvot;
        //näin kaikissa divScore-instansseissa näkyy kaikkien tarrojen "StickerScore" jolloin seuraava tallennus
        //ei ylikirjoita arvoja nollaksi 
        DivideScript[] tempArray = GameObject.FindObjectsOfType<DivideScript>();
        foreach (DivideScript i in tempArray)
        {
            i.LoadScore();
        }

    }
    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/divscore.txt";
        if (File.Exists(path))
        {
            scoreData data = saveScore.LoadDivScore();
            divJungleStarCount = data.divJungleStarCount;
            divSpaceStarCount = data.divJungleStarCount;

            avocadoStickerScore = data.avocadoStickerScore;
            toolStickerScore = data.toolStickerScore;
            tigerStickerScore = data.tigerStickerScore;

            driedfishStickerScore = data.driedfishStickerScore;
            octopusStickerScore = data.octopusStickerScore;
            catStickerScore = data.catStickerScore;

            Debug.Log("div stickers loaded");
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
        divScore = 0;
        scoreCount.text = divScore.ToString();
    }
    public void CheckStickers()
    {
        if (avocadoStickerScore == 1)
        {
            stickerOne.gameObject.SetActive(true);
        }
        if (toolStickerScore == 1)
        {
            stickerTwo.gameObject.SetActive(true);
        }
        if (tigerStickerScore == 1)
        {
            stickerThree.gameObject.SetActive(true);
        }
        if (driedfishStickerScore == 1)
        {
            stickerFour.gameObject.SetActive(true);
        }
        if (octopusStickerScore == 1)
        {
            stickerFive.gameObject.SetActive(true);
        }
        if (catStickerScore == 1)
        {
            stickerSix.gameObject.SetActive(true);
        }
    }

    public void StarCount()
    {
        divJungleStarCount = avocadoStickerScore + toolStickerScore + tigerStickerScore;
        divSpaceStarCount = driedfishStickerScore + octopusStickerScore + catStickerScore;
    }

    public void CheckStars()
    {
        switch (worldIndex)
        {
            case 2:
                if (divJungleStarCount == 1)
                {
                    divStars.GetComponent<Image>().sprite = oneStar;
                    menuStars.GetComponent<Image>().sprite = oneStar;
                }
                if (divJungleStarCount == 2)
                {
                    divStars.GetComponent<Image>().sprite = twoStar;
                    menuStars.GetComponent<Image>().sprite = twoStar;
                }
                if (divJungleStarCount == 3)
                {
                    divStars.GetComponent<Image>().sprite = threeStar;
                    menuStars.GetComponent<Image>().sprite = threeStar;
                }
                break;
            case 3:
                if (divSpaceStarCount == 1)
                {
                    divStars.GetComponent<Image>().sprite = oneStar;
                    menuStars.GetComponent<Image>().sprite = oneStar;
                }
                if (divSpaceStarCount == 2)
                {
                    divStars.GetComponent<Image>().sprite = twoStar;
                    menuStars.GetComponent<Image>().sprite = twoStar;
                }
                if (divSpaceStarCount == 3)
                {
                    divStars.GetComponent<Image>().sprite = threeStar;
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
        scoreCount.text = divScore.ToString();
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
        avocadoStickerScore = 0;
        toolStickerScore = 0;
        tigerStickerScore = 0;
        driedfishStickerScore = 0;
        octopusStickerScore = 0;
        catStickerScore = 0;
        SaveScore();
    }


    public void DivJungle()
        {
        //secondValue = randomizer.Next(2, 11);
        //int tempValue = randomizer.Next(2, 11);
        //firstValue = secondValue * tempValue;
        //quotient.Value = 0;

        //if ((addend1 + addend2 == sum.Value)
        //&& (minuend - subtrahend == difference.Value)
        //&& (multiplicand * multiplier == product.Value)
        //&& (dividend / divisor == quotient.Value))
        //    return true;
        //else
        //    return false;

        if (levelIndex == 1)
        {
            firstValue = Random.Range(1, 10);
            secondValue = Random.Range(1, 5);
            thirdValue = firstValue * secondValue;
            if(firstValue > secondValue)
            {
                fourthValue = secondValue;
            }
            else
            {
                fourthValue = firstValue;
            }
            FirstValue.text = thirdValue.ToString();
            SecondValue.text = fourthValue.ToString();

            finalValue = firstValue / secondValue;

            //First Alterntive
            tempValue = Random.Range(0, 10);
            while (tempValue == finalValue)
            {
                tempValue = Random.Range(0, 10);
            }
            Alternative1 = tempValue;
            //Second Alternative
            tempValue = Random.Range(0, 10);
            while (tempValue == finalValue || (tempValue == Alternative1))
            {
                tempValue = Random.Range(0, 10);
            }
            Alternative2 = tempValue;
        }
        if (levelIndex == 2)
        {
            firstValue = Random.Range(1, 10);
            secondValue = Random.Range(1, 5);
            thirdValue = firstValue * secondValue;
            if (firstValue > secondValue)
            {
                fourthValue = secondValue;
            }
            else
            {
                fourthValue = firstValue;
            }
            FirstValue.text = thirdValue.ToString();
            SecondValue.text = fourthValue.ToString();

            finalValue = firstValue / secondValue;

            //First Alterntive
            tempValue = Random.Range(0, 10);
            while (tempValue == finalValue)
            {
                tempValue = Random.Range(0, 10);
            }
            Alternative1 = tempValue;
            //Second Alternative
            tempValue = Random.Range(0, 10);
            while (tempValue == finalValue || (tempValue == Alternative1))
            {
                tempValue = Random.Range(0, 10);
            }
            Alternative2 = tempValue;
        }
        if (levelIndex == 3)
        {
            firstValue = Random.Range(1, 10);
            secondValue = Random.Range(1, 5);
            thirdValue = firstValue * secondValue;
            if (firstValue > secondValue)
            {
                fourthValue = secondValue;
            }
            else
            {
                fourthValue = firstValue;
            }
            FirstValue.text = thirdValue.ToString();
            SecondValue.text = fourthValue.ToString();

            finalValue = firstValue / secondValue;

            //First Alterntive
            tempValue = Random.Range(0, 10);
            while (tempValue == finalValue)
            {
                tempValue = Random.Range(0, 10);
            }
            Alternative1 = tempValue;
            //Second Alternative
            tempValue = Random.Range(0, 10);
            while (tempValue == finalValue || (tempValue == Alternative1))
            {
                tempValue = Random.Range(0, 10);
            }
            Alternative2 = tempValue;
        }
        if (levelIndex == 4)
        {
            firstValue = Random.Range(1, 10);
            secondValue = Random.Range(1, 5);
            thirdValue = firstValue * secondValue;
            if (firstValue > secondValue)
            {
                fourthValue = secondValue;
            }
            else
            {
                fourthValue = firstValue;
            }
            FirstValue.text = thirdValue.ToString();
            SecondValue.text = fourthValue.ToString();

            finalValue = firstValue / secondValue;

            //First Alterntive
            tempValue = Random.Range(0, 10);
            while (tempValue == finalValue)
            {
                tempValue = Random.Range(0, 10);
            }
            Alternative1 = tempValue;
            //Second Alternative
            tempValue = Random.Range(0, 10);
            while (tempValue == finalValue || (tempValue == Alternative1))
            {
                tempValue = Random.Range(0, 10);
            }
            Alternative2 = tempValue;
        }
        if (levelIndex == 5)
        {
            firstValue = Random.Range(1, 10);
            secondValue = Random.Range(1, 5);
            thirdValue = firstValue * secondValue;
            if (firstValue > secondValue)
            {
                fourthValue = secondValue;
            }
            else
            {
                fourthValue = firstValue;
            }
            FirstValue.text = thirdValue.ToString();
            SecondValue.text = fourthValue.ToString();

            finalValue = firstValue / secondValue;

            //First Alterntive
            tempValue = Random.Range(0, 10);
            while (tempValue == finalValue)
            {
                tempValue = Random.Range(0, 10);
            }
            Alternative1 = tempValue;
            //Second Alternative
            tempValue = Random.Range(0, 10);
            while (tempValue == finalValue || (tempValue == Alternative1))
            {
                tempValue = Random.Range(0, 10);
            }
            Alternative2 = tempValue;
        }
        if (levelIndex == 6)
        {
            firstValue = Random.Range(1, 10);
            secondValue = Random.Range(1, 5);
            thirdValue = firstValue * secondValue;
            if (firstValue > secondValue)
            {
                fourthValue = secondValue;
            }
            else
            {
                fourthValue = firstValue;
            }
            FirstValue.text = thirdValue.ToString();
            SecondValue.text = fourthValue.ToString();

            finalValue = firstValue / secondValue;

            //First Alterntive
            tempValue = Random.Range(0, 10);
            while (tempValue == finalValue)
            {
                tempValue = Random.Range(0, 10);
            }
            Alternative1 = tempValue;
            //Second Alternative
            tempValue = Random.Range(0, 10);
            while (tempValue == finalValue || (tempValue == Alternative1))
            {
                tempValue = Random.Range(0, 10);
            }
            Alternative2 = tempValue;
        }

        if (firstValue - secondValue < 2)
            {
                tempValue = secondValue;
                secondValue = firstValue;
                firstValue = tempValue;
            }

            Function.text = "/";
            finalValue = thirdValue / fourthValue;


            tempValue = Random.Range(2, 20);
            while (tempValue == finalValue)
            {
                tempValue = Random.Range(2, 20);
            }
            Alternative1 = tempValue;

            //Second Alternative
            tempValue = Random.Range(2, 20);
            while (tempValue == finalValue || (tempValue == Alternative1))
            {
                tempValue = Random.Range(2, 20);
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
            if (divScore >= 5)
            {
                switchOn.gameObject.SetActive(true);
                Animal.GetComponent<Animator>().SetBool("Dance", true);
                switchOff.gameObject.SetActive(false);
                switch (levelIndex)
                {
                    case 1:
                        if (avocadoStickerScore < 1)
                        {
                            avocadoStickerScore += 1;
                            Debug.Log("Apple unlocked");
                        }
                        break;
                    case 2:
                        if (toolStickerScore < 1)
                        {
                            toolStickerScore += 1;
                            Debug.Log("Basket unlocked");
                        }
                        break;
                    case 3:
                        if (tigerStickerScore < 1)
                        {
                            tigerStickerScore += 1;
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
            DivJungle();
            Animal.GetComponent<Animator>().SetBool("Happy", false);
        }
    }
    public void ResetSpace()
    {
        {
            if (divScore >= 5)
            {
                switchOn.gameObject.SetActive(true);
                switchOff.gameObject.SetActive(false);
                switch (levelIndex)
                {
                    case 1:
                        if (avocadoStickerScore < 1)
                        {
                            avocadoStickerScore += 1;
                            Debug.Log("Apple unlocked");
                        }
                        break;
                    case 2:
                        if (toolStickerScore < 1)
                        {
                            toolStickerScore += 1;
                            Debug.Log("Basket unlocked");
                        }
                        break;
                    case 3:
                        if (tigerStickerScore < 1)
                        {
                            tigerStickerScore += 1;
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
            DivSpace();
        }
    }

    IEnumerator Correct()
    {
        Score();
        CheckStickers();
        StarCount();
        CheckStars();
        AnswerSpot.text = finalValue.ToString();
        scoreCount.text = divScore.ToString();
        yield return new WaitForSeconds(1f);
        ResetJungle();
    }

    public void Score()
    {
        divScore += 1;
    }

   
    public void DivSpace()
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

        Function.text = "/";
        finalValue = firstValue / secondValue;


        tempValue = Random.Range(50, 1900);
        while (tempValue == finalValue)
        {
            tempValue = Random.Range(50, 1900);
        }
        Alternative1 = tempValue;

        //Second Alternative
        tempValue = Random.Range(50, 1900);
        while (tempValue == finalValue || (tempValue == Alternative1))
        {
            tempValue = Random.Range(50, 1900);
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
        DivJungle();
        ResetScore();
    }
    public void StartSpace()
    {
        ResetSpace();
        DivSpace();
        ResetScore();
    }


}

