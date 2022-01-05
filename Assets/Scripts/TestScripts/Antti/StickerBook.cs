using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StickerBook : MonoBehaviour
{
    public GameObject stickerOne, stickerTwo, stickerThree, stickerFour, stickerFive, stickerSix, stickerSeven, stickerEight, stickerNine;
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

    // Start is called before the first frame update
    void Start()
    {
        LoadSumScore();
        LoadSubScore();
        LoadCountScore();
        //LoadMultScore();
        //LoadDivScore();
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

    }

    //public void ResetScore()
    //{
    //    if (allScoresZero = true)
    //    {
    //        appleStickerScore = 0;
    //        basketStickerScore = 0;
    //        pigStickerScore = 0;
    //        carrotStickerScore = 0;
    //        bucketStickerScore = 0;
    //        bunnyStickerScore = 0;
    //        threeCornStickerScore = 0;
    //        twoCornStickerScore = 0;
    //        lambStickerScore = 0;
    //    }
    //}
}
