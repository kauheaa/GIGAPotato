using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplyScript : MonoBehaviour
{
    int firstValue, secondValue, tempValue, finalValue, Alternative1, Alternative2;
    [SerializeField] public int sumScore = 0;
    [SerializeField] public int sumStarCount = 0;
    [SerializeField] public int appleStickerScore = 0;
    [SerializeField] public int basketStickerScore = 0;
    [SerializeField] public int pigStickerScore = 0;
    public int levelIndex = 0;
    private int stick1, stick2, stick3;
    public Text FirstValue, SecondValue, Function, Alt1, Alt2, Alt3, AnswerSpot, scoreCount;
    public GameObject ONE, TWO, THREE, appleSpawn, apple, stickerOne, stickerTwo, stickerThree;
    public Sprite oneStar, twoStar, threeStar;
    public GameObject sumStars, menuStars;
    public Button button1, button2, button3;
    public Sprite blueButton, redButton, greenButton;
    [SerializeField] private Transform switchOff, switchOn;


    public void SaveScore()
    {
        saveScore.SaveMultScore(this);

        //luo väliaikaisen listan, joka etsii hierarkiassa olevat sumScore instanssit ja käy läpi,
        //käy läpi kaikki löytämänsä instanssit ja käskee niitä hakemaan tietokannasta kaikki tallennetut arvot;
        //näin kaikissa sumScore-instansseissa näkyy kaikkien tarrojen "StickerScore" jolloin seuraava tallennus
        //ei ylikirjoita arvoja nollaksi 
        MultiplyScript[] tempArray = GameObject.FindObjectsOfType<MultiplyScript>();
        foreach (MultiplyScript i in tempArray)
        {
            i.LoadScore();
        }

    }
    public void LoadScore()
    {
        scoreData data = saveScore.LoadSumScore();
        sumStarCount = data.sumStarCount;
        appleStickerScore = data.appleStickerScore;
        basketStickerScore = data.basketStickerScore;
        pigStickerScore = data.pigStickerScore;
        Debug.Log("apple: " + appleStickerScore + " basket: " + basketStickerScore + " pig: " + pigStickerScore);

    }

    public void SetLevelIndex(int index)
    {
        levelIndex = index;
    }

    public void ResetScore()
    {
        sumScore = 0;
        scoreCount.text = sumScore.ToString();
    }

    private void Start()
    {
        scoreCount.text = sumScore.ToString();
        AnswerSpot.text = "?";

    }

    // Update is called once per frame
    void Update()
    {
        //   score = int.Parse(scoreCount.text);

        sumStarCount = appleStickerScore + basketStickerScore + pigStickerScore;

        if (appleStickerScore == 1)
        {
            stickerOne.gameObject.SetActive(true);
        }
        if (basketStickerScore == 1)
        {
            stickerTwo.gameObject.SetActive(true);
        }
        if (pigStickerScore == 1)
        {
            stickerThree.gameObject.SetActive(true);
        }
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
        }
    }

    public void SumFarm()
    {

        firstValue = Random.Range(2, 10);
        secondValue = Random.Range(2, 10);
        FirstValue.text = firstValue.ToString();
        SecondValue.text = secondValue.ToString();

        if (firstValue - secondValue < 2)
        {
            tempValue = secondValue;
            secondValue = firstValue;
            firstValue = tempValue;
        }

        Function.text = "+";
        finalValue = firstValue * secondValue;


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

    public void ResetV()
    {
        if (sumScore >= 5)
        {
            switchOn.gameObject.SetActive(true);
            switchOff.gameObject.SetActive(false);
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

        }

        ONE.gameObject.SetActive(false);
        button1.interactable = true;
        TWO.gameObject.SetActive(false);
        button2.interactable = true;
        THREE.gameObject.SetActive(false);
        button3.interactable = true;
        AnswerSpot.text = "?";
        SumFarm();
    }

    public void ResetJungle()
    {
        {
            if (sumScore >= 5)
            {
                switchOn.gameObject.SetActive(true);
                switchOff.gameObject.SetActive(false);
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

            }

            ONE.gameObject.SetActive(false);
            button1.interactable = true;
            TWO.gameObject.SetActive(false);
            button2.interactable = true;
            THREE.gameObject.SetActive(false);
            button3.interactable = true;
            AnswerSpot.text = "?";
           MultJungle();
        }
    }
    public void ResetSpace()
    {
        {
            if (sumScore >= 5)
            {
                switchOn.gameObject.SetActive(true);
                switchOff.gameObject.SetActive(false);
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
        scoreCount.text = sumScore.ToString();
        yield return new WaitForSeconds(1f);
        ResetJungle();
    }

    public void Score()
    {
        sumScore += 1;
    }

    public void MultJungle()
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

