using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubScript : MonoBehaviour
{
    int firstValue, secondValue, tempValue, finalValue, Alternative1, Alternative2;
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
    [SerializeField] private Transform switchOff, switchOn;
    public Text FirstValue, SecondValue, Function, Alt1, Alt2, Alt3, AnswerSpot, scoreCount;
    public GameObject ONE, TWO, THREE, appleSpawn, apple, stickerOne, stickerTwo, stickerThree, StickerFour, StickerFive, StickerSix, StickerSeven, StickerEight, StickerNine;
    public Sprite oneStar, twoStar, threeStar;
    public GameObject subStars, menuStars;
    public Button button1, button2, button3;
    public Sprite blueButton, redButton, greenButton;
    public GameObject Animal;


    public void SaveScore()
    {
        saveScore.SaveSubScore(this);

        //luo väliaikaisen listan, joka etsii hierarkiassa olevat subScore instanssit ja käy läpi,
        //käy läpi kaikki löytämänsä instanssit ja käskee niitä hakemaan tietokannasta kaikki tallennetut arvot;
        //näin kaikissa subScore-instansseissa näkyy kaikkien tarrojen "StickerScore" jolloin seuraava tallennus
        //ei ylikirjoita arvoja nollaksi 
        SubScript[] tempArray = GameObject.FindObjectsOfType<SubScript>();
        foreach (SubScript i in tempArray)
        {
            i.LoadScore();
        }

    }
    public void LoadScore()
    {
        scoreData data = saveScore.LoadSubScore();
        subStarCount = data.subStarCount;
        carrotStickerScore = data.carrotStickerScore;
        bucketStickerScore = data.bucketStickerScore;
        bunnyStickerScore = data.bunnyStickerScore;
        Debug.Log("carrot: " + carrotStickerScore + " bucket: " + bucketStickerScore + " bunny: " + bunnyStickerScore);

    }

    public void SetLevelIndex(int index)
    {
        levelIndex = index;
    }

    public void ResetScore()
    {
        subScore = 0;
        scoreCount.text = subScore.ToString();
    }

    private void Start()
    {
        LoadScore();
        AnswerSpot.text = "?";
        
    }
    // Update is called once per frame
    void Update()
    {
        //   score = int.Parse(scoreCount.text);

        subStarCount = carrotStickerScore + bucketStickerScore + bunnyStickerScore;

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
    }

    public void SubFarm()
    {
        if (levelIndex == 1)
        {
            firstValue = Random.Range(6, 10);
            secondValue = Random.Range(1, 5);
            FirstValue.text = firstValue.ToString();
            SecondValue.text = secondValue.ToString();
        }
        if (levelIndex == 2)
        {
            firstValue = Random.Range(11, 15);
            secondValue = Random.Range(1, 10);
            FirstValue.text = firstValue.ToString();
            SecondValue.text = secondValue.ToString();
        }
        if (levelIndex == 3)
        {
            firstValue = Random.Range(20, 25);
            secondValue = Random.Range(1, 19);
            FirstValue.text = firstValue.ToString();
            SecondValue.text = secondValue.ToString();
        }
        if (levelIndex == 4)
        {
            firstValue = Random.Range(20, 25);
            secondValue = Random.Range(20, 25);
            FirstValue.text = firstValue.ToString();
            SecondValue.text = secondValue.ToString();
        }
        if (levelIndex == 5)
        {
            firstValue = Random.Range(20, 25);
            secondValue = Random.Range(20, 25);
            FirstValue.text = firstValue.ToString();
            SecondValue.text = secondValue.ToString();
        }
        if (levelIndex == 6)
        {
            firstValue = Random.Range(20, 25);
            secondValue = Random.Range(20, 25);
            FirstValue.text = firstValue.ToString();
            SecondValue.text = secondValue.ToString();
        }
        if (levelIndex == 7)
        {
            firstValue = Random.Range(20, 25);
            secondValue = Random.Range(20, 25);
            FirstValue.text = firstValue.ToString();
            SecondValue.text = secondValue.ToString();
        }
        if (levelIndex == 8)
        {
            firstValue = Random.Range(20, 25);
            secondValue = Random.Range(20, 25);
            FirstValue.text = firstValue.ToString();
            SecondValue.text = secondValue.ToString();
        }
        if (levelIndex == 9)
        {
            firstValue = Random.Range(20, 25);
            secondValue = Random.Range(20, 25);
            FirstValue.text = firstValue.ToString();
            SecondValue.text = secondValue.ToString();
        }

        if (firstValue - secondValue < 0)
        {
            tempValue = secondValue;
            secondValue = firstValue;
            firstValue = tempValue;
        }

        Function.text = "-";
        finalValue = firstValue - secondValue;


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
        if (subScore >= 5)
        {
            switchOn.gameObject.SetActive(true);
            Animal.GetComponent<Animator>().SetBool("Dance", true);
            switchOff.gameObject.SetActive(false);
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