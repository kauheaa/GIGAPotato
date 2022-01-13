using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class StickerBook : MonoBehaviour
{
    public SumScript sum;

    // All starCounts
    public int sumStarCount, sumJungleStarCount, sumSpaceStarCount;
    public int subStarCount, subJungleStarCount, subSpaceStarCount;
    public int countStarCount;
    public int multJungleStarCount, multSpaceStarCount;
    public int divJungleStarCount, divSpaceStarCount;

    // Farm stickers
    public GameObject appleSticker, basketSticker, pigSticker;
    public GameObject carrotSticker, bucketSticker, bunnySticker;
    public GameObject threeCornSticker, twoCornSticker, lambSticker;

    // Jungle stickers
    public GameObject bananaSticker, clusterSticker, monkeySticker;
    public GameObject coconutSticker, ocularsSticker, slothSticker;
    public GameObject lycheeSticker, pitahayaSticker, frogSticker;
    public GameObject avocadoSticker, toolSticker, tigerSticker;

    // Space stickers
    public GameObject asteroidSticker, blackholeSticker, llamaSticker;
    public GameObject starSticker, planetSticker, cowSticker;
    public GameObject flagSticker, rocketSticker, laikaSticker;
    public GameObject driedfishSticker, octopusSticker, catSticker;

    // Farm sticker scores
    [SerializeField] public int appleStickerScore = 0;
    [SerializeField] public int basketStickerScore = 0;
    [SerializeField] public int pigStickerScore = 0;

    [SerializeField] public int carrotStickerScore = 0;
    [SerializeField] public int bucketStickerScore = 0;
    [SerializeField] public int bunnyStickerScore = 0;

    [SerializeField] public int threeCornStickerScore = 0;
    [SerializeField] public int twoCornStickerScore = 0;
    [SerializeField] public int lambStickerScore = 0;

    // Jungle sticker scores
    [SerializeField] public int bananaStickerScore = 0;
    [SerializeField] public int clusterStickerScore = 0;
    [SerializeField] public int monkeyStickerScore = 0;

    [SerializeField] public int coconutStickerScore = 0;
    [SerializeField] public int ocularsStickerScore = 0;
    [SerializeField] public int slothStickerScore = 0;

    [SerializeField] public int lycheeStickerScore = 0;
    [SerializeField] public int pitahayaStickerScore = 0;
    [SerializeField] public int frogStickerScore = 0;

    [SerializeField] public int avocadoStickerScore = 0;
    [SerializeField] public int toolStickerScore = 0;
    [SerializeField] public int tigerStickerScore = 0;

    // Space sticker scores
    [SerializeField] public int asteroidStickerScore = 0;
    [SerializeField] public int blackholeStickerScore = 0;
    [SerializeField] public int llamaStickerScore = 0;

    [SerializeField] public int starStickerScore = 0;
    [SerializeField] public int planetStickerScore = 0;
    [SerializeField] public int cowStickerScore = 0;

    [SerializeField] public int flagStickerScore = 0;
    [SerializeField] public int rocketStickerScore = 0;
    [SerializeField] public int laikaStickerScore = 0;

    [SerializeField] public int driedfishStickerScore = 0;
    [SerializeField] public int octopusStickerScore = 0;
    [SerializeField] public int catStickerScore = 0;

    // Sticker book last page stats
    [SerializeField] public int statsAllInt = 0;
    [SerializeField] public int statsCollectedInt = 0;
    [SerializeField] public int statsFarmInt = 0;
    [SerializeField] public int statsJungleInt = 0;
    [SerializeField] public int statsSpaceInt = 0;

    public Text statsAll;
    public Text statsFarm;
    public Text statsJungle;
    public Text statsSpace;
    public Text congrats;
    public Text allCollected;


    public void SaveBook()
    {
        saveScore.SaveBook(this);

        // Est‰‰ instanssiduplikaatteja p‰ivitt‰m‰tt‰ scorea nollaksi
        StickerBook[] tempArray = GameObject.FindObjectsOfType<StickerBook>();
        foreach (StickerBook i in tempArray)
        {
            i.LoadBook();
        }
    }
    public void LoadBook()
    {
        string path = Application.persistentDataPath + "/booksave.txt";
        if (File.Exists(path))
        {
            scoreData data = saveScore.LoadBook();
            {
                // Load all starCounts
                sumStarCount = data.sumStarCount;
                sumJungleStarCount = data.sumJungleStarCount;
                sumSpaceStarCount = data.sumSpaceStarCount;
                subStarCount = data.subStarCount;
                subJungleStarCount = data.subStarCount;
                subSpaceStarCount = data.subStarCount;
                countStarCount = data.countStarCount;
                multJungleStarCount = data.multJungleStarCount;
                multSpaceStarCount = data.multSpaceStarCount;
                divJungleStarCount = data.divJungleStarCount;
                divSpaceStarCount = data.divSpaceStarCount;

                // Load Farm stickers
                appleStickerScore = data.appleStickerScore;
                basketStickerScore = data.basketStickerScore;
                pigStickerScore = data.pigStickerScore;

                carrotStickerScore = data.carrotStickerScore;
                bucketStickerScore = data.bucketStickerScore;
                bunnyStickerScore = data.bunnyStickerScore;

                threeCornStickerScore = data.threeCornStickerScore;
                twoCornStickerScore = data.twoCornStickerScore;
                lambStickerScore = data.lambStickerScore;

                // Load Jungle stickers
                bananaStickerScore = data.bananaStickerScore;
                clusterStickerScore = data.clusterStickerScore;
                monkeyStickerScore = data.monkeyStickerScore;

                coconutStickerScore = data.coconutStickerScore;
                ocularsStickerScore = data.ocularsStickerScore;
                slothStickerScore = data.slothStickerScore;

                lycheeStickerScore = data.lycheeStickerScore;
                pitahayaStickerScore = data.pitahayaStickerScore;
                frogStickerScore = data.frogStickerScore;

                avocadoStickerScore = data.avocadoStickerScore;
                toolStickerScore = data.toolStickerScore;
                tigerStickerScore = data.tigerStickerScore;

                // Load Space stickers
                asteroidStickerScore = data.asteroidStickerScore;
                blackholeStickerScore = data.blackholeStickerScore;
                llamaStickerScore = data.llamaStickerScore;

                starStickerScore = data.starStickerScore;
                planetStickerScore = data.planetStickerScore;
                cowStickerScore = data.cowStickerScore;

                flagStickerScore = data.flagStickerScore;
                rocketStickerScore = data.rocketStickerScore;
                laikaStickerScore = data.laikaStickerScore;

                driedfishStickerScore = data.driedfishStickerScore;
                octopusStickerScore = data.octopusStickerScore;
                catStickerScore = data.catStickerScore;

                Debug.Log("Stickers and StarCounts loaded");
            }
        }
        else
        {
            SaveBook();
        }
    }

        //public void LoadSumScore()
        //{
        //        scoreData data = saveScore.LoadSumScore();
        //        appleStickerScore = data.appleStickerScore;
        //        basketStickerScore = data.basketStickerScore;
        //        pigStickerScore = data.pigStickerScore;

        //        bananaStickerScore = data.bananaStickerScore;
        //        clusterStickerScore = data.clusterStickerScore;
        //        monkeyStickerScore = data.monkeyStickerScore;

        //        asteroidStickerScore = data.asteroidStickerScore;
        //        blackholeStickerScore = data.blackholeStickerScore;
        //        llamaStickerScore = data.llamaStickerScore;
        //}

        //public void LoadSubScore()
        //{
        //    scoreData data = saveScore.LoadSubScore();
        //    carrotStickerScore = data.carrotStickerScore;
        //    bucketStickerScore = data.bucketStickerScore;
        //    bunnyStickerScore = data.bunnyStickerScore;

        //    coconutStickerScore = data.coconutStickerScore;
        //    ocularsStickerScore = data.ocularsStickerScore;
        //    slothStickerScore = data.slothStickerScore;

        //    starStickerScore = data.starStickerScore;
        //    planetStickerScore = data.planetStickerScore;
        //    cowStickerScore = data.cowStickerScore;
        //}

        //public void LoadCountScore()
        //{
        //    scoreData data = saveScore.LoadCountScore();
        //    threeCornStickerScore = data.threeCornStickerScore;
        //    twoCornStickerScore = data.twoCornStickerScore;
        //    lambStickerScore = data.lambStickerScore;
        //}
        //public void LoadMultScore()
        //{
        //    scoreData data = saveScore.LoadMultScore();
        //    lycheeStickerScore = data.lycheeStickerScore;
        //    pitahayaStickerScore = data.pitahayaStickerScore;
        //    frogStickerScore = data.frogStickerScore;

        //    flagStickerScore = data.flagStickerScore;
        //    rocketStickerScore = data.rocketStickerScore;
        //    laikaStickerScore = data.laikaStickerScore;
        //}
        //public void LoadDivScore()
        //{
        //    scoreData data = saveScore.LoadDivScore();
        //    avocadoStickerScore = data.avocadoStickerScore;
        //    toolStickerScore = data.toolStickerScore;
        //    tigerStickerScore = data.tigerStickerScore;

        //    driedfishStickerScore = data.driedfishStickerScore;
        //    octopusStickerScore = data.octopusStickerScore;
        //    catStickerScore = data.catStickerScore;
        //}



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
    public void StarCount()
    {
        sumStarCount = appleStickerScore + basketStickerScore + pigStickerScore;
        sumJungleStarCount = bananaStickerScore + clusterStickerScore + monkeyStickerScore;
        sumSpaceStarCount = asteroidStickerScore + blackholeStickerScore + llamaStickerScore;
    }
    public void unlockApple()
    {
        if (appleStickerScore < 1)
        {
            appleStickerScore += 1;
        }
    }

    public void UpdateAll()
    {
        //LoadSumScore();
        //LoadSubScore();
        //LoadCountScore();
        //LoadMultScore();
        //LoadDivScore();
        //LoadBook();
        UpdateStats();
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateAll();
        // Unlock farm stickers
        if (appleStickerScore == 1)
        {
            appleSticker.gameObject.SetActive(true);
        }
        if (basketStickerScore == 1)
        {
            basketSticker.gameObject.SetActive(true);
        }
        if (pigStickerScore == 1)
        {
            pigSticker.gameObject.SetActive(true);
        }
        if (carrotStickerScore == 1)
        {
            carrotSticker.gameObject.SetActive(true);
        }
        if (bucketStickerScore == 1)
        {
            bucketSticker.gameObject.SetActive(true);
        }
        if (bunnyStickerScore == 1)
        {
            bunnySticker.gameObject.SetActive(true);
        }
        if (threeCornStickerScore == 1)
        {
            threeCornSticker.gameObject.SetActive(true);
        }
        if (twoCornStickerScore == 1)
        {
            twoCornSticker.gameObject.SetActive(true);
        }
        if (lambStickerScore == 1)
        {
            lambSticker.gameObject.SetActive(true);
        }
        // Unlock jungle stickers
        if (bananaStickerScore == 1)
        {
            bananaSticker.gameObject.SetActive(true);
        }
        if (clusterStickerScore == 1)
        {
            clusterSticker.gameObject.SetActive(true);
        }
        if (monkeyStickerScore == 1)
        {
            monkeySticker.gameObject.SetActive(true);
        }
        if (coconutStickerScore == 1)
        {
            coconutSticker.gameObject.SetActive(true);
        }
        if (ocularsStickerScore == 1)
        {
            ocularsSticker.gameObject.SetActive(true);
        }
        if (slothStickerScore == 1)
        {
            slothSticker.gameObject.SetActive(true);
        }
        if (lycheeStickerScore == 1)
        {
            lycheeSticker.gameObject.SetActive(true);
        }
        if (pitahayaStickerScore == 1)
        {
            pitahayaSticker.gameObject.SetActive(true);
        }
        if (frogStickerScore == 1)
        {
            frogSticker.gameObject.SetActive(true);
        }
        if (avocadoStickerScore == 1)
        {
            avocadoSticker.gameObject.SetActive(true);
        }
        if (toolStickerScore == 1)
        {
            toolSticker.gameObject.SetActive(true);
        }
        if (tigerStickerScore == 1)
        {
            tigerSticker.gameObject.SetActive(true);
        }
        // Unlock Space stickers
        if (asteroidStickerScore == 1)
        {
            asteroidSticker.gameObject.SetActive(true);
        }
        if (blackholeStickerScore == 1)
        {
            blackholeSticker.gameObject.SetActive(true);
        }
        if (llamaStickerScore == 1)
        {
            llamaSticker.gameObject.SetActive(true);
        }
        if (starStickerScore == 1)
        {
            starSticker.gameObject.SetActive(true);
        }
        if (planetStickerScore == 1)
        {
            planetSticker.gameObject.SetActive(true);
        }
        if (cowStickerScore == 1)
        {
            cowSticker.gameObject.SetActive(true);
        }
        if (flagStickerScore == 1)
        {
            flagSticker.gameObject.SetActive(true);
        }
        if (rocketStickerScore == 1)
        {
            rocketSticker.gameObject.SetActive(true);
        }
        if (laikaStickerScore == 1)
        {
            laikaSticker.gameObject.SetActive(true);
        }
        if (driedfishStickerScore == 1)
        {
            driedfishSticker.gameObject.SetActive(true);
        }
        if (octopusStickerScore == 1)
        {
            octopusSticker.gameObject.SetActive(true);
        }
        if (catStickerScore == 1)
        {
            catSticker.gameObject.SetActive(true);
        }

    }

}
