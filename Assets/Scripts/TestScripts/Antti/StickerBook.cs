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
    [SerializeField] public int carrotStickerScore = 0;
    [SerializeField] public int bucketStickerScore = 0;
    [SerializeField] public int bunnyStickerScore = 0;
    [SerializeField] public int threeCornStickerScore = 0;
    [SerializeField] public int twoCornStickerScore = 0;
    [SerializeField] public int lambStickerScore = 0;
    public bool AllScoresZero = false;
    //   public List<Sticker> StickerList;


    public void LoadSumScore()
    {
        scoreData data = saveScore.LoadSumScore();
        appleStickerScore = data.appleStickerScore;
        basketStickerScore = data.basketStickerScore;
        pigStickerScore = data.pigStickerScore;
    }

    public void LoadSubScore()
    {
        scoreData data = saveScore.LoadSubScore();
        carrotStickerScore = data.carrotStickerScore;
        bucketStickerScore = data.bucketStickerScore;
        bunnyStickerScore = data.bunnyStickerScore;
    }

    public void LoadCountScore()
    {
        scoreData data = saveScore.LoadCountScore();
        threeCornStickerScore = data.threeCornStickerScore;
        twoCornStickerScore = data.twoCornStickerScore;
        lambStickerScore = data.lambStickerScore;
    }

    // Start is called before the first frame update
    void Start()
    {
        LoadSumScore();
        LoadSubScore();
        LoadCountScore();
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
