using UnityEngine;
using UnityEngine.UI;

public class StickerBook : MonoBehaviour
{
    public StarCount starCount;
    public SaveDataManager save;
    public MenuControl canvasControl;

    public GameObject stickerbookButton; // UI canvas button to open sticker book
    public Button closeBookButton;
    public GameObject fingerPointing;

    public GameObject loginButton;  // button to open log in spread
    public GameObject signinButton; // button to open register spread
    public GameObject logoutButton; // button to log out

    public Text playerDisplay;      // where player name shows
    [SerializeField] private Transform playerStats;
    public GameObject avatar;       // player avatar indicating logged in status
    public Sprite loggedInAvatar;   // sprite for logged in avatar
    public Sprite loggedOutAvatar;  // sprite for logged out avatar

    // stickerbook spreads
    [SerializeField] private Transform FirstSpread;
    [SerializeField] private Transform RegisterSpread;
    [SerializeField] private Transform LoginSpread;
    [SerializeField] private Transform Spread1;
    [SerializeField] private Transform Spread2;
    [SerializeField] private Transform Spread3;
    [SerializeField] private Transform Spread4;
    [SerializeField] private Transform Spread5;
    [SerializeField] private Transform Spread6;

    public int worldIndex; // defines which world stickerbook is in, assigned in inspector

    // calculate scripts in scene, assigned in inspector
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

    // Sticker stats
    [SerializeField] public int statsAllInt = 0;
    [SerializeField] public int statsCollectedInt = 0;
    [SerializeField] public int statsFarmInt = 0;
    [SerializeField] public int statsJungleInt = 0;
    [SerializeField] public int statsSpaceInt = 0;

    // Sticker stat display objects on book stat page
    public Text statsAll;
    public Text statsFarm;
    public Text statsJungle;
    public Text statsSpace;
    public Text congrats;
    public Text allCollected;
    public string congratsText;
    public string congratsTitle;


    public void DestroyHand()
    {
        Destroy(fingerPointing);
    }

    public void UpdatePlayerInfo() // updates first page name, avatar and register/login/logout button visibility
    {
        if (DatabaseManager.LoggedIn)
        {
            playerDisplay.text = DatabaseManager.username;  // updates name showing on the first page
            avatar.gameObject.GetComponent<Image>().sprite = loggedInAvatar;    // updates logged in avatar
            closeBookButton.interactable = true;
            if (GameObject.Find("fingerPointing") != null)
            {
                DestroyHand();
            }
            playerStats.gameObject.SetActive(true);
            loginButton.gameObject.SetActive(false);        // hides login button
            signinButton.gameObject.SetActive(false);       // hides register button
            logoutButton.gameObject.SetActive(true);        // reveals log out button

        }
        else
        {
            playerDisplay.text = "NO ONE...\n\n LOG IN TO SAVE YOUR PROGRESS!";               // resets name showing on the first page
            avatar.gameObject.GetComponent<Image>().sprite = loggedOutAvatar;   // updates logged out avatar
            //closeBookButton.interactable = false;
            if (GameObject.Find("fingerPointing") != null)
            {
                fingerPointing.gameObject.SetActive(true);
            }
            playerStats.gameObject.SetActive(false);
            loginButton.gameObject.SetActive(true);         // reveals login button
            signinButton.gameObject.SetActive(true);        // reveals register button
            logoutButton.gameObject.SetActive(false);       // hides log out button
        }
    }



    public void ResetButtonFunction()
    {
        canvasControl.OpenResetWarning();
    }
    
    public void CloseResetWarning()
    {
        canvasControl.CloseResetWarning();
    }

    public void ResetWarningOK()
    {
        ResetStickers();
        CloseResetWarning();
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
            case 1: bucketSticker.gameObject.SetActive(true); break;
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

    public void CountStars()    // updates all book starCounts and sprites to all sum/sub/count/div/mult starCounts
    {
        starCount.CountStars();
    }

    public void UpdateStats() // Updates player sticker stats on the second page
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
            congrats.text = congratsTitle;
            allCollected.text = congratsText;
        }
        else
        {
            congrats.text = "";
            allCollected.text = "";
        }
    }

    public void UpdateLevelButtons() // updates sprites to all sum/sub/count/div/mult based on stickerscores and world index
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
    public void UpdateAll()     // updates: player name and avatar, login buttons, stats - unlocks/hides stickers - level button sprites - book starcount and all sprites based on book sticker scores
    {
        UpdatePlayerInfo();     // updates first page name, avatar sprite and register/login/logout button visibility
        UpdateStickers();       // unlocks stickers if stickerScore = 1, hides stickers if stickerScore = 0
        CountStars();           // updates book starCounts based on sticker scores, and all sum/sub/count/div/mult starCount sprites
        UpdateStats();          // updates the book stats page values
        UpdateLevelButtons();   // updates sprites to all sum/sub/count/div/mult based on stickerscores and world index
    }

    public void CallSaveData() // sets database score by combining all book sticker scores into a string, saves score into database for logged in username
    {
        save.CallSaveData();
    }

    // AnimatedLevelEnd button function
    public void AnimatedLevelEnd() // saves sticker scores | plays stickerbook button anim | updates stickers, stars, buttons, player info and stats | plays sticker button anim
    {
        canvasControl.Save();   // plays stickerbook button "Saved" animation and then "NewStickers" animation
    }

    public void ResetStickers() // Resets the whole stickerbook, saves scores as 0 and updates all (player info, login buttons, stickers, stars, level buttons)
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
        CallSaveData(); // sets database score by combining all book sticker scores into a string, saves score into database for logged in username
        UpdateAll();    // updates: player name and avatar, login buttons, stats - unlocks/hides stickers - level button sprites - book starcount and all sprites based on book sticker scores
    }
    
    public void LogOut()    // wipes player name, resets stickers and updates all (player info, login buttons, stickers, stars, level buttons)
    {
        DatabaseManager.LogOut();
        ResetStickers();    // Resets the whole stickerbook, saves scores as 0 and updates all (player info, login buttons, stickers, stars, level buttons)
    }


    public void LoadBook()
    {
        if (DatabaseManager.score != "") // updates book sticker scores to match DatabaseManager sticker scores if DatabaseManager score exists
        {
            //farm
            appleStickerScore = DatabaseManager.appleStickerScore;
            basketStickerScore = DatabaseManager.basketStickerScore;
            pigStickerScore = DatabaseManager.pigStickerScore;
            carrotStickerScore = DatabaseManager.carrotStickerScore;
            bucketStickerScore = DatabaseManager.bucketStickerScore;
            bunnyStickerScore = DatabaseManager.bunnyStickerScore;
            threeCornStickerScore = DatabaseManager.threeCornStickerScore;
            twoCornStickerScore = DatabaseManager.twoCornStickerScore;
            lambStickerScore = DatabaseManager.lambStickerScore;
            //jungle
            bananaStickerScore = DatabaseManager.bananaStickerScore;
            clusterStickerScore = DatabaseManager.clusterStickerScore;
            monkeyStickerScore = DatabaseManager.monkeyStickerScore;
            coconutStickerScore = DatabaseManager.coconutStickerScore;
            ocularsStickerScore = DatabaseManager.ocularsStickerScore;
            slothStickerScore = DatabaseManager.slothStickerScore;
            lycheeStickerScore = DatabaseManager.lycheeStickerScore;
            pitahayaStickerScore = DatabaseManager.pitahayaStickerScore;
            frogStickerScore = DatabaseManager.frogStickerScore;
            avocadoStickerScore = DatabaseManager.avocadoStickerScore;
            toolStickerScore = DatabaseManager.toolStickerScore;
            tigerStickerScore = DatabaseManager.tigerStickerScore;
            // space
            asteroidStickerScore = DatabaseManager.asteroidStickerScore;
            blackholeStickerScore = DatabaseManager.blackholeStickerScore;
            llamaStickerScore = DatabaseManager.llamaStickerScore;
            starStickerScore = DatabaseManager.starStickerScore;
            planetStickerScore = DatabaseManager.planetStickerScore;
            cowStickerScore = DatabaseManager.cowStickerScore;
            flagStickerScore = DatabaseManager.flagStickerScore;
            rocketStickerScore = DatabaseManager.rocketStickerScore;
            laikaStickerScore = DatabaseManager.laikaStickerScore;
            driedfishStickerScore = DatabaseManager.driedfishStickerScore;
            octopusStickerScore = DatabaseManager.octopusStickerScore;
            catStickerScore = DatabaseManager.catStickerScore;

            UpdateAll();    // updates: player name and avatar, login buttons, stats - unlocks/hides stickers - level button sprites - book starcount and all sprites based on book sticker scores
            Debug.Log("Stickerbook scores are updated to match Database Score");
        }
        else
        {
            Debug.Log("Database score is null.");
        }
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

    public void NoNewStickers()
    {
        stickerbookButton.GetComponent<Animator>().SetBool("NewStickers", false);
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }






    void OnApplicationQuit()
    {
        LogOut();
    }

    // Stickerbook spreads
    public void OpenSpread1()
    {
        Spread1.gameObject.SetActive(true);
        Spread2.gameObject.SetActive(false);
        Spread3.gameObject.SetActive(false);
        Spread4.gameObject.SetActive(false);
        Spread5.gameObject.SetActive(false);
        Spread6.gameObject.SetActive(false);
        LoginSpread.gameObject.SetActive(false);
        RegisterSpread.gameObject.SetActive(false);
        FirstSpread.gameObject.SetActive(false);
    }
    public void OpenSpread2()
    {
        Spread2.gameObject.SetActive(true);
        Spread3.gameObject.SetActive(false);
        Spread4.gameObject.SetActive(false);
        Spread5.gameObject.SetActive(false);
        Spread6.gameObject.SetActive(false);
        LoginSpread.gameObject.SetActive(false);
        RegisterSpread.gameObject.SetActive(false);
        FirstSpread.gameObject.SetActive(false);
    }
    public void OpenSpread3()
    {
        Spread3.gameObject.SetActive(true);
        Spread4.gameObject.SetActive(false);
        Spread5.gameObject.SetActive(false);
        Spread6.gameObject.SetActive(false);
        LoginSpread.gameObject.SetActive(false);
        RegisterSpread.gameObject.SetActive(false);
        FirstSpread.gameObject.SetActive(false);
    }
    public void OpenSpread4()
    {
        Spread4.gameObject.SetActive(true);
        Spread5.gameObject.SetActive(false);
        Spread6.gameObject.SetActive(false);
        LoginSpread.gameObject.SetActive(false);
        RegisterSpread.gameObject.SetActive(false);
        FirstSpread.gameObject.SetActive(false);
    }
    public void OpenSpread5()
    {
        Spread5.gameObject.SetActive(true);
        Spread6.gameObject.SetActive(false);
        LoginSpread.gameObject.SetActive(false);
        RegisterSpread.gameObject.SetActive(false);
        FirstSpread.gameObject.SetActive(false);
    }
    public void OpenSpread6()
    {
        Spread6.gameObject.SetActive(true);
        LoginSpread.gameObject.SetActive(false);
        RegisterSpread.gameObject.SetActive(false);
        FirstSpread.gameObject.SetActive(false);
    }
    public void OpenLoginSpread()
    {
        FirstSpread.gameObject.SetActive(true);
        LoginSpread.gameObject.SetActive(true);
        RegisterSpread.gameObject.SetActive(false);
    }
    public void OpenRegisterSpread()
    {
        FirstSpread.gameObject.SetActive(true);
        RegisterSpread.gameObject.SetActive(true);
        LoginSpread.gameObject.SetActive(false);
    }

    public void OpenFirstSpread()
    {
        FirstSpread.gameObject.SetActive(true);
        LoginSpread.gameObject.SetActive(false);
        RegisterSpread.gameObject.SetActive(false);
    }

    public void CloseBook()
    {
        canvasControl.CloseStickerBook();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (starCount.worldIndex == 0 && DatabaseManager.LoggedIn == true)
        {
            closeBookButton.interactable = true;
        }
        LoadBook();
        worldIndex = starCount.worldIndex;
        sum1 = canvasControl.sum1;
        sum2 = canvasControl.sum2;
        sum3 = canvasControl.sum3;
        sub1 = canvasControl.sub1;
        sub2 = canvasControl.sub2;
        sub3 = canvasControl.sub3;
        count1 = canvasControl.count1;
        count2 = canvasControl.count2;
        count3 = canvasControl.count3;
        mult1 = canvasControl.mult1;
        mult2 = canvasControl.mult2;
        mult3 = canvasControl.mult3;
        div1 = canvasControl.div1;
        div2 = canvasControl.div2;
        div3 = canvasControl.div3;

    UpdateAll(); // updates: player info, login buttons, stats - unlocks/hides stickers - level button sprites - starcount scores and sprites
        //if (DatabaseManager.LoggedIn == false)
        //{
        //    OpenFirstSpread();
        //}
    }

}
