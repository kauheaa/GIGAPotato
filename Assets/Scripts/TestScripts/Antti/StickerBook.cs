using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class StickerBook : MonoBehaviour
{
    public StarCount starCount;
    public WriteToFile writeToFile;

    [SerializeField] private Transform registerSpread;
    [SerializeField] private Transform loginSpread;

    public string stickerScores;
    public Text test;


    public int bookIndex = 0;
    public int worldIndex;

    public SumScript sum1;
    public SumScript sum2;
    public SumScript sum3;
    public SubScript sub1;
    public SubScript sub2;
    public SubScript sub3;
    public CountScript count1;
    public CountScript count2;
    public CountScript count3;
    public MultiplyScript mult1;
    public MultiplyScript mult2;
    public MultiplyScript mult3;
    public DivideScript div1;
    public DivideScript div2;
    public DivideScript div3;

    // Player name
    public string playerName;
    public Text player;

    // All starCounts
    public int sumFarmStarCount, sumJungleStarCount, sumSpaceStarCount;
    public int subFarmStarCount, subJungleStarCount, subSpaceStarCount;
    public int countFarmStarCount, countJungleStarCount, countSpaceStarCount;
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
    }
    public void LoadBook()
    {
        string path = Application.persistentDataPath + "/booksave.txt";
        if (File.Exists(path))
        {
            scoreData data = saveScore.LoadBook();
            {
                sumFarmStarCount = data.sumFarmStarCount;
                sumJungleStarCount = data.sumJungleStarCount;
                sumSpaceStarCount = data.sumSpaceStarCount;
                subFarmStarCount = data.subFarmStarCount;
                subJungleStarCount = data.subJungleStarCount;
                subSpaceStarCount = data.subSpaceStarCount;
                countFarmStarCount = data.countFarmStarCount;
                countJungleStarCount = data.countJungleStarCount;
                countSpaceStarCount = data.countSpaceStarCount;
                multJungleStarCount = data.multJungleStarCount;
                multSpaceStarCount = data.multSpaceStarCount;
                divJungleStarCount = data.divJungleStarCount;
                divSpaceStarCount = data.divSpaceStarCount;

                appleStickerScore = data.appleStickerScore;
                basketStickerScore = data.basketStickerScore;
                pigStickerScore = data.pigStickerScore;
                carrotStickerScore = data.carrotStickerScore;
                bucketStickerScore = data.bucketStickerScore;
                bunnyStickerScore = data.bunnyStickerScore;
                threeCornStickerScore = data.threeCornStickerScore;
                twoCornStickerScore = data.twoCornStickerScore;
                lambStickerScore = data.lambStickerScore;

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
            }
            Debug.Log("Book loaded");
        }
        else
        {
            SaveBook();
            Debug.Log("Empty save created");
        }
    }

    public void GoToRegister()
    {
        registerSpread.gameObject.SetActive(true);
    }
    public void GoToLogin()
    {
        loginSpread.gameObject.SetActive(true);
    }

    public void CloseRegister()
    {
        registerSpread.gameObject.SetActive(false);
    }

    public void CloseLogin()
    {
        loginSpread.gameObject.SetActive(false);
    }

    public void UpdateStarCounts()
    {
        sumFarmStarCount = appleStickerScore + basketStickerScore + pigStickerScore;
        sumJungleStarCount = bananaStickerScore + clusterStickerScore + monkeyStickerScore;
        sumSpaceStarCount = asteroidStickerScore + blackholeStickerScore + llamaStickerScore;

        subFarmStarCount = carrotStickerScore + bucketStickerScore + bunnyStickerScore;
        subJungleStarCount = coconutStickerScore + ocularsStickerScore + slothStickerScore;
        subSpaceStarCount = starStickerScore + planetStickerScore + cowStickerScore;

        countFarmStarCount = threeCornStickerScore + twoCornStickerScore + lambStickerScore;
        countJungleStarCount = 0;
        countSpaceStarCount = 0;

        multJungleStarCount = lycheeStickerScore + pitahayaStickerScore + frogStickerScore;
        multSpaceStarCount = flagStickerScore + rocketStickerScore + laikaStickerScore;
        divJungleStarCount = avocadoStickerScore + toolStickerScore + tigerStickerScore;
        divSpaceStarCount = driedfishStickerScore + octopusStickerScore + catStickerScore;
    }

    public void CountStars()
    {
        starCount.CountStars();
    }


// Farm stickers
    public void UnlockApple()
    {
        if (appleStickerScore < 1)
        {
            appleStickerScore += 1;
        }
    }
    public void UnlockBasket()
    {
        if (basketStickerScore < 1)
        {
            basketStickerScore += 1;
        }
    }
    public void UnlockPig()
    {
        if (pigStickerScore < 1)
        {
            pigStickerScore += 1;
        }
    }

    public void UnlockCarrot()
    {
        if (carrotStickerScore < 1)
        {
            carrotStickerScore += 1;
        }
    }
    public void UnlockBucket()
    {
        if (bucketStickerScore < 1)
        {
            bucketStickerScore += 1;
        }
    }
    public void UnlockBunny()
    {
        if (bunnyStickerScore < 1)
        {
            bunnyStickerScore += 1;
        }
    }

    public void UnlockThreeCorn()
    {
        if (threeCornStickerScore < 1)
        {
            threeCornStickerScore += 1;
        }
    }
    public void UnlockTwoCorn()
    {
        if (twoCornStickerScore < 1)
        {
            twoCornStickerScore += 1;
        }
    }
    public void UnlockLamb()
    {
        if (lambStickerScore < 1)
        {
            lambStickerScore += 1;
        }
    }

    // Jungle Stickers
    public void UnlockBanana()
    {
        if (bananaStickerScore < 1)
        {
            bananaStickerScore += 1;
        }
    }
    public void UnlockCluster()
    {
        if (clusterStickerScore < 1)
        {
            clusterStickerScore += 1;
        }
    }
    public void UnlockMonkey()
    {
        if (monkeyStickerScore < 1)
        {
            monkeyStickerScore += 1;
        }
    }

    public void UnlockCoconut()
    {
        if (coconutStickerScore < 1)
        {
            coconutStickerScore += 1;
        }
    }

    public void UnlockOculars()
    {
        if (ocularsStickerScore < 1)
        {
            ocularsStickerScore += 1;
        }
    }

    public void UnlockSloth()
    {
        if (slothStickerScore < 1)
        {
            slothStickerScore += 1;
        }
    }
    public void UnlockLychee()
    {
        if (lycheeStickerScore < 1)
        {
            lycheeStickerScore += 1;
        }
    }
    public void UnlockPitahaya()
    {
        if (pitahayaStickerScore < 1)
        {
            pitahayaStickerScore += 1;
        }
    }
    public void UnlockFrog()
    {
        if (frogStickerScore < 1)
        {
            frogStickerScore += 1;
        }
    }
    public void UnlockAvocado()
    {
        if (avocadoStickerScore < 1)
        {
            avocadoStickerScore += 1;
        }
    }
    public void UnlockTool()
    {
        if (toolStickerScore < 1)
        {
            toolStickerScore += 1;
        }
    }
    public void UnlockTiger()
    {
        if (tigerStickerScore < 1)
        {
            tigerStickerScore += 1;
        }
    }
    public void UnlockAsteroid()
    {
        if (asteroidStickerScore < 1)
        {
            asteroidStickerScore += 1;
        }
    }
    public void UnlockBlackhole()
    {
        if (blackholeStickerScore < 1)
        {
            blackholeStickerScore += 1;
        }
    }
    public void UnlockLlama()
    {
        if (llamaStickerScore < 1)
        {
            llamaStickerScore += 1;
        }
    }

    public void UnlockStar()
    {
        if (starStickerScore < 1)
        {
            starStickerScore += 1;
        }
    }
    public void UnlockPlanet()
    {
        if (planetStickerScore < 1)
        {
            planetStickerScore += 1;
        }
    }
    public void UnlockCow()
    {
        if (cowStickerScore < 1)
        {
            cowStickerScore += 1;
        }
    }
    public void UnlockFlag()
    {
        if (flagStickerScore < 1)
        {
            flagStickerScore += 1;
        }
    }
    public void UnlockRocket()
    {
        if (rocketStickerScore < 1)
        {
            rocketStickerScore += 1;
        }
    }
    public void UnlockLaika()
    {
        if (laikaStickerScore < 1)
        {
            laikaStickerScore += 1;
        }
    }

    public void UnlockDriedfish()
    {
        if (driedfishStickerScore < 1)
        {
            driedfishStickerScore += 1;
        }
    }
    public void UnlockOctopus()
    {
        if (octopusStickerScore < 1)
        {
            octopusStickerScore += 1;
        }
    }
    public void UnlockCat()
    {
        if (catStickerScore < 1)
        {
            catStickerScore += 1;
        }
    }


    public void UpdateStickers()
    {
        // Update Farm stickers
        switch (appleStickerScore)
        {
            case 0: appleSticker.gameObject.SetActive(false); break;
            case 1: appleSticker.gameObject.SetActive(true); break;
        }
        switch (basketStickerScore)
        {
            case 0: basketSticker.gameObject.SetActive(false); break;
            case 1: basketSticker.gameObject.SetActive(true); break;
        }
        switch (pigStickerScore)
        {
            case 0: pigSticker.gameObject.SetActive(false); break;
            case 1: pigSticker.gameObject.SetActive(true); break;
        }
        switch (carrotStickerScore)
        {
            case 0: carrotSticker.gameObject.SetActive(false); break;
            case 1: carrotSticker.gameObject.SetActive(true); break;
        }
        switch (bucketStickerScore)
        {
            case 0: bucketSticker.gameObject.SetActive(false); break;
            case 1: bucketSticker.gameObject.SetActive(true);  break;
        }
        switch (bunnyStickerScore)
        {
            case 0: bunnySticker.gameObject.SetActive(false); break;
            case 1: bunnySticker.gameObject.SetActive(true); break;
        }
        switch (threeCornStickerScore)
        {
            case 0: threeCornSticker.gameObject.SetActive(false); break;
            case 1: threeCornSticker.gameObject.SetActive(true); break;
        }
        switch (twoCornStickerScore)
        {
            case 0: twoCornSticker.gameObject.SetActive(false); break;
            case 1: twoCornSticker.gameObject.SetActive(true); break;
        }
        switch (lambStickerScore)
        {
            case 0: lambSticker.gameObject.SetActive(false); break;
            case 1: lambSticker.gameObject.SetActive(true); break;
        }

        // Update Jungle stickers
        switch (bananaStickerScore)
        {
            case 0: bananaSticker.gameObject.SetActive(false); break;
            case 1: bananaSticker.gameObject.SetActive(true); break;
        }
        switch (clusterStickerScore)
        {
            case 0: clusterSticker.gameObject.SetActive(false); break;
            case 1: clusterSticker.gameObject.SetActive(true); break;
        }
        switch (monkeyStickerScore)
        {
            case 0: monkeySticker.gameObject.SetActive(false); break;
            case 1: monkeySticker.gameObject.SetActive(true); break;
        }
        switch (coconutStickerScore)
        {
            case 0: coconutSticker.gameObject.SetActive(false); break;
            case 1: coconutSticker.gameObject.SetActive(true); break;
        }
        switch (ocularsStickerScore)
        {
            case 0: ocularsSticker.gameObject.SetActive(false); break;
            case 1: ocularsSticker.gameObject.SetActive(true); break;
        }
        switch (slothStickerScore)
        {
            case 0: slothSticker.gameObject.SetActive(false); break;
            case 1: slothSticker.gameObject.SetActive(true); break;
        }
        switch (lycheeStickerScore)
        {
            case 0: lycheeSticker.gameObject.SetActive(false); break;
            case 1: lycheeSticker.gameObject.SetActive(true); break;
        }
        switch (pitahayaStickerScore)
        {
            case 0: pitahayaSticker.gameObject.SetActive(false); break;
            case 1: pitahayaSticker.gameObject.SetActive(true); break;
        }
        switch (frogStickerScore)
        {
            case 0: frogSticker.gameObject.SetActive(false); break;
            case 1: frogSticker.gameObject.SetActive(true); break;
        }
        switch (avocadoStickerScore)
        {
            case 0: avocadoSticker.gameObject.SetActive(false); break;
            case 1: avocadoSticker.gameObject.SetActive(true); break;
        }
        switch (toolStickerScore)
        {
            case 0: toolSticker.gameObject.SetActive(false); break;
            case 1: toolSticker.gameObject.SetActive(true); break;
        }
        switch (tigerStickerScore)
        {
            case 0: tigerSticker.gameObject.SetActive(false); break;
            case 1: tigerSticker.gameObject.SetActive(true); break;
        }

        // Update Space stickers
        switch (asteroidStickerScore)
        {
            case 0: asteroidSticker.gameObject.SetActive(false); break;
            case 1: asteroidSticker.gameObject.SetActive(true); break;
        }
        switch (blackholeStickerScore)
        {
            case 0: blackholeSticker.gameObject.SetActive(false); break;
            case 1: blackholeSticker.gameObject.SetActive(true); break;
        }
        switch (llamaStickerScore)
        {
            case 0: llamaSticker.gameObject.SetActive(false); break;
            case 1: llamaSticker.gameObject.SetActive(true); break;
        }
        switch (starStickerScore)
        {
            case 0: starSticker.gameObject.SetActive(false); break;
            case 1: starSticker.gameObject.SetActive(true); break;
        }
        switch (planetStickerScore)
        {
            case 0: planetSticker.gameObject.SetActive(false); break;
            case 1: planetSticker.gameObject.SetActive(true); break;
        }
        switch (cowStickerScore)
        {
            case 0: cowSticker.gameObject.SetActive(false); break;
            case 1: cowSticker.gameObject.SetActive(true); break;
        }
        switch (flagStickerScore)
        {
            case 0: flagSticker.gameObject.SetActive(false); break;
            case 1: flagSticker.gameObject.SetActive(true); break;
        }
        switch (rocketStickerScore)
        {
            case 0: rocketSticker.gameObject.SetActive(false); break;
            case 1: rocketSticker.gameObject.SetActive(true); break;
        }
        switch (laikaStickerScore)
        {
            case 0: laikaSticker.gameObject.SetActive(false); break;
            case 1: laikaSticker.gameObject.SetActive(true); break;
        }
        switch (driedfishStickerScore)
        {
            case 0: driedfishSticker.gameObject.SetActive(false); break;
            case 1: driedfishSticker.gameObject.SetActive(true); break;
        }
        switch (octopusStickerScore)
        {
            case 0: octopusSticker.gameObject.SetActive(false); break;
            case 1: octopusSticker.gameObject.SetActive(true); break;
        }
        switch (catStickerScore)
        {
            case 0: catSticker.gameObject.SetActive(false); break;
            case 1: catSticker.gameObject.SetActive(true); break;
        }
    }

    public void UpdateStats() // Updates stats on the last page of Sticker Book
    {
        statsAllInt = 33;
        statsCollectedInt = appleStickerScore + basketStickerScore + pigStickerScore + bananaStickerScore + clusterStickerScore + monkeyStickerScore + asteroidStickerScore + blackholeStickerScore + llamaStickerScore + carrotStickerScore + bucketStickerScore + bunnyStickerScore + coconutStickerScore + ocularsStickerScore + slothStickerScore + starStickerScore + planetStickerScore + cowStickerScore + threeCornStickerScore + twoCornStickerScore + lambStickerScore + lycheeStickerScore + pitahayaStickerScore + frogStickerScore + flagStickerScore + rocketStickerScore + laikaStickerScore + avocadoStickerScore + toolStickerScore + tigerStickerScore + driedfishStickerScore + octopusStickerScore + catStickerScore;
        statsFarmInt = appleStickerScore + basketStickerScore + pigStickerScore + carrotStickerScore + bucketStickerScore + bunnyStickerScore + threeCornStickerScore + twoCornStickerScore + lambStickerScore;
        statsJungleInt = bananaStickerScore + clusterStickerScore + monkeyStickerScore + coconutStickerScore + ocularsStickerScore + slothStickerScore + lycheeStickerScore + pitahayaStickerScore + frogStickerScore + avocadoStickerScore + toolStickerScore + tigerStickerScore;
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

    public void UpdateLevelButtons()
    {
        if (worldIndex > 0)
        {
            sum1.UpdateLevelButtons();
            sum2.UpdateLevelButtons();
            sum3.UpdateLevelButtons();
            sub1.UpdateLevelButtons();
            sub2.UpdateLevelButtons();
            sub3.UpdateLevelButtons();
            if (sum1.levelIndex == 1)
            {
                count1.UpdateLevelButtons();
                count2.UpdateLevelButtons();
                count3.UpdateLevelButtons();
            }
            if (sum1.levelIndex >= 2)
            {
                mult1.UpdateLevelButtons();
                mult2.UpdateLevelButtons();
                mult3.UpdateLevelButtons();
                div1.UpdateLevelButtons();
                div2.UpdateLevelButtons();
                div3.UpdateLevelButtons();
            }
        }
    }
    public void UpdateAll() // Updates Stickers, stars and stats
    {
        UpdateStickers();
        CountStars();
        UpdateStats();
        UpdateLevelButtons();
    }

    // Start is called before the first frame update
    void Start()
    {
        LoadBook();
        UpdateAll();
    }


    public void ResetStickers() // Resets the whole stickerbook
    {
        // Reset StarCounts
        sumFarmStarCount = 0;
        sumJungleStarCount = 0;
        sumSpaceStarCount = 0;
        subFarmStarCount = 0;
        subJungleStarCount = 0;
        subSpaceStarCount = 0;
        countFarmStarCount = 0;
        multJungleStarCount = 0;
        multSpaceStarCount = 0;
        divJungleStarCount = 0;
        divSpaceStarCount = 0;

        // Reset Farm stickers
        appleStickerScore = 0;
        basketStickerScore = 0;
        pigStickerScore = 0;

        carrotStickerScore = 0;
        bucketStickerScore = 0;
        bunnyStickerScore = 0;

        threeCornStickerScore = 0;
        twoCornStickerScore = 0;
        lambStickerScore = 0;

        // Reset Jungle stickers
        bananaStickerScore = 0;
        clusterStickerScore = 0;
        monkeyStickerScore = 0;

        coconutStickerScore = 0;
        ocularsStickerScore = 0;
        slothStickerScore = 0;

        lycheeStickerScore = 0;
        pitahayaStickerScore = 0;
        frogStickerScore = 0;

        avocadoStickerScore = 0;
        toolStickerScore = 0;
        tigerStickerScore = 0;

        // Reset Space stickers
        asteroidStickerScore = 0;
        blackholeStickerScore = 0;
        llamaStickerScore = 0;

        starStickerScore = 0;
        planetStickerScore = 0;
        cowStickerScore = 0;

        flagStickerScore = 0;
        rocketStickerScore = 0;
        laikaStickerScore = 0;

        driedfishStickerScore = 0;
        octopusStickerScore = 0;
        catStickerScore = 0;
        SaveBook();
        UpdateAll();
    }

    public void Update()
    {

    }
}
