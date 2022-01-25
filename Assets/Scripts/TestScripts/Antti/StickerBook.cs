using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StickerBook : MonoBehaviour
{
    public GameObject stickerOne, stickerTwo, stickerThree, stickerFour, stickerFive, stickerSix, stickerSeven, stickerEight, stickerNine;
    public GameObject stickerTen, stickerEleven, stickerTwelve, stickerThirteen, stickerFourteen, stickerFifteen, stickerSixteen, stickerSeventeen, stickerEighteen;
    public GameObject stickerNineteen, stickerTwenty, stickerTwentyone, stickerTwentytwo, stickerTwentythree, stickerTwentyfour, stickerTwentyfive, stickerTwentysix, stickerTwentyseven;
    public GameObject stickerTwentyeight, stickerTwentynine, stickerThirty, stickerThirtyone, stickerThirtytwo, stickerThirtythree;

    [SerializeField] public int appleStickerScore = 0;
    [SerializeField] public int basketStickerScore = 0;
    [SerializeField] public int pigStickerScore = 0;
    [SerializeField] public int bananaStickerScore = 0;
    [SerializeField] public int clusterStickerScore = 0;
    [SerializeField] public int monkeyStickerScore = 0;
    [SerializeField] public int asteroidStickerScore = 0;
    [SerializeField] public int blackholeStickerScore = 0;
    [SerializeField] public int llamaStickerScore = 0;

    [SerializeField] public int carrotStickerScore = 0;
    [SerializeField] public int bucketStickerScore = 0;
    [SerializeField] public int bunnyStickerScore = 0;
    [SerializeField] public int coconutStickerScore = 0;
    [SerializeField] public int ocularsStickerScore = 0;
    [SerializeField] public int slothStickerScore = 0;
    [SerializeField] public int starStickerScore = 0;
    [SerializeField] public int planetStickerScore = 0;
    [SerializeField] public int cowStickerScore = 0;

    [SerializeField] public int threeCornStickerScore = 0;
    [SerializeField] public int twoCornStickerScore = 0;
    [SerializeField] public int lambStickerScore = 0;

    [SerializeField] public int lycheeStickerScore = 0;
    [SerializeField] public int pitahayaStickerScore = 0;
    [SerializeField] public int frogStickerScore = 0;
    [SerializeField] public int flagStickerScore = 0;
    [SerializeField] public int rocketStickerScore = 0;
    [SerializeField] public int laikaStickerScore = 0;

    [SerializeField] public int avocadoStickerScore = 0;
    [SerializeField] public int toolStickerScore = 0;
    [SerializeField] public int tigerStickerScore = 0;
    [SerializeField] public int driedfishStickerScore = 0;
    [SerializeField] public int octopusStickerScore = 0;
    [SerializeField] public int catStickerScore = 0;

    public Text statsAll;
    public Text statsFarm;
    public Text statsJungle;
    public Text statsSpace;
    public Text congrats;
    public Text allCollected;

    [SerializeField] public int statsAllInt = 0;
    [SerializeField] public int statsCollectedInt = 0;
    [SerializeField] public int statsFarmInt = 0;
    [SerializeField] public int statsJungleInt = 0;
    [SerializeField] public int statsSpaceInt = 0;

    //public bool AllScoresZero = false;
    //   public List<Sticker> StickerList;


    public void LoadSumScore()
    {
        scoreData data = saveScore.LoadSumScore();
        appleStickerScore = data.appleStickerScore;
        basketStickerScore = data.basketStickerScore;
        pigStickerScore = data.pigStickerScore;

        bananaStickerScore = data.bananaStickerScore;
        clusterStickerScore = data.clusterStickerScore;
        monkeyStickerScore = data.monkeyStickerScore;

        asteroidStickerScore = data.asteroidStickerScore;
        blackholeStickerScore = data.blackholeStickerScore;
        llamaStickerScore = data.llamaStickerScore;
    }

    public void LoadSubScore()
    {
        scoreData data = saveScore.LoadSubScore();
        carrotStickerScore = data.carrotStickerScore;
        bucketStickerScore = data.bucketStickerScore;
        bunnyStickerScore = data.bunnyStickerScore;

        coconutStickerScore = data.coconutStickerScore;
        ocularsStickerScore = data.ocularsStickerScore;
        slothStickerScore = data.slothStickerScore;

        starStickerScore = data.starStickerScore;
        planetStickerScore = data.planetStickerScore;
        cowStickerScore = data.cowStickerScore;
    }

    public void LoadCountScore()
    {
        scoreData data = saveScore.LoadCountScore();
        threeCornStickerScore = data.threeCornStickerScore;
        twoCornStickerScore = data.twoCornStickerScore;
        lambStickerScore = data.lambStickerScore;
    }
    public void LoadMultScore()
    {
        scoreData data = saveScore.LoadMultScore();
        lycheeStickerScore = data.lycheeStickerScore;
        pitahayaStickerScore = data.pitahayaStickerScore;
        frogStickerScore = data.frogStickerScore;

        flagStickerScore = data.flagStickerScore;
        rocketStickerScore = data.rocketStickerScore;
        laikaStickerScore = data.laikaStickerScore;
    }
    public void LoadDivScore()
    {
        scoreData data = saveScore.LoadDivScore();
        avocadoStickerScore = data.avocadoStickerScore;
        toolStickerScore = data.toolStickerScore;
        tigerStickerScore = data.tigerStickerScore;

        driedfishStickerScore = data.driedfishStickerScore;
        octopusStickerScore = data.octopusStickerScore;
        catStickerScore = data.catStickerScore;
    }



    public void UpdateStats()
    {
        statsAllInt = 33;
        statsCollectedInt = appleStickerScore + basketStickerScore + pigStickerScore + bananaStickerScore + clusterStickerScore + monkeyStickerScore + asteroidStickerScore + blackholeStickerScore + llamaStickerScore + carrotStickerScore + bucketStickerScore + bunnyStickerScore + coconutStickerScore + ocularsStickerScore + slothStickerScore + starStickerScore + planetStickerScore + cowStickerScore + threeCornStickerScore + twoCornStickerScore + lambStickerScore + lycheeStickerScore + pitahayaStickerScore + flagStickerScore + rocketStickerScore + laikaStickerScore + avocadoStickerScore + toolStickerScore + tigerStickerScore + driedfishStickerScore + octopusStickerScore + catStickerScore;
        statsFarmInt = appleStickerScore + basketStickerScore + pigStickerScore + carrotStickerScore + bucketStickerScore + bunnyStickerScore + threeCornStickerScore + twoCornStickerScore + lambStickerScore;
        statsJungleInt = bananaStickerScore + clusterStickerScore + monkeyStickerScore + coconutStickerScore + ocularsStickerScore + slothStickerScore + lycheeStickerScore + pitahayaStickerScore + avocadoStickerScore + toolStickerScore + tigerStickerScore;
        statsSpaceInt = asteroidStickerScore + blackholeStickerScore + llamaStickerScore + starStickerScore + planetStickerScore + cowStickerScore + flagStickerScore + rocketStickerScore + laikaStickerScore + driedfishStickerScore + octopusStickerScore + catStickerScore;

        statsAll.text = statsCollectedInt + " / " + statsAllInt;
        statsFarm.text = statsFarmInt + " / 9";
        statsJungle.text = statsJungleInt + " / 12";
        statsSpace.text = statsSpaceInt + " / 12";

        if (statsCollectedInt == statsAllInt)
        {
            congrats.text = "CONGRATULATIONS!";
            allCollected.text = "YOU'VE COLLECTED ALL STICKERS!";
        }
    }

    public void UpdateAll()
    {
        LoadSumScore();
        LoadSubScore();
        LoadCountScore();
        LoadMultScore();
        LoadDivScore();
        UpdateStats();
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateAll();
        //FARM
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
        if (carrotStickerScore == 1)
        {
            stickerFour.gameObject.SetActive(true);
        }
        if (bucketStickerScore == 1)
        {
            stickerFive.gameObject.SetActive(true);
        }
        if (bunnyStickerScore == 1)
        {
            stickerSix.gameObject.SetActive(true);
        }
        if (threeCornStickerScore == 1)
        {
            stickerSeven.gameObject.SetActive(true);
        }
        if (twoCornStickerScore == 1)
        {
            stickerEight.gameObject.SetActive(true);
        }
        if (lambStickerScore == 1)
        {
            stickerNine.gameObject.SetActive(true);
        }
        //JUNGLE
        if (bananaStickerScore == 1)
        {
            stickerTen.gameObject.SetActive(true);
        }
        if (clusterStickerScore == 1)
        {
            stickerEleven.gameObject.SetActive(true);
        }
        if (monkeyStickerScore == 1)
        {
            stickerTwelve.gameObject.SetActive(true);
        }
        if (coconutStickerScore == 1)
        {
            stickerThirteen.gameObject.SetActive(true);
        }
        if (ocularsStickerScore == 1)
        {
            stickerFourteen.gameObject.SetActive(true);
        }
        if (slothStickerScore == 1)
        {
            stickerFifteen.gameObject.SetActive(true);
        }
        if (lycheeStickerScore == 1)
        {
            stickerSixteen.gameObject.SetActive(true);
        }
        if (pitahayaStickerScore == 1)
        {
            stickerSeventeen.gameObject.SetActive(true);
        }
        if (frogStickerScore == 1)
        {
            stickerEighteen.gameObject.SetActive(true);
        }
        if (avocadoStickerScore == 1)
        {
            stickerNineteen.gameObject.SetActive(true);
        }
        if (toolStickerScore == 1)
        {
            stickerTwenty.gameObject.SetActive(true);
        }
        if (tigerStickerScore == 1)
        {
            stickerTwentyone.gameObject.SetActive(true);
        }
        //SPACE
        if (asteroidStickerScore == 1)
        {
            stickerTwentytwo.gameObject.SetActive(true);
        }
        if (blackholeStickerScore == 1)
        {
            stickerTwentythree.gameObject.SetActive(true);
        }
        if (llamaStickerScore == 1)
        {
            stickerTwentyfour.gameObject.SetActive(true);
        }
        if (starStickerScore == 1)
        {
            stickerTwentyfive.gameObject.SetActive(true);
        }
        if (planetStickerScore == 1)
        {
            stickerTwentysix.gameObject.SetActive(true);
        }
        if (cowStickerScore == 1)
        {
            stickerTwentyseven.gameObject.SetActive(true);
        }
        if (flagStickerScore == 1)
        {
            stickerTwentyeight.gameObject.SetActive(true);
        }
        if (rocketStickerScore == 1)
        {
            stickerTwentynine.gameObject.SetActive(true);
        }
        if (laikaStickerScore == 1)
        {
            stickerThirty.gameObject.SetActive(true);
        }
        if (driedfishStickerScore == 1)
        {
            stickerThirtyone.gameObject.SetActive(true);
        }
        if (octopusStickerScore == 1)
        {
            stickerThirtytwo.gameObject.SetActive(true);
        }
        if (catStickerScore == 1)
        {
            stickerThirtythree.gameObject.SetActive(true);
        }

    }

}
