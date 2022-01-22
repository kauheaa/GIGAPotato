using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public StickerBook book;
    public InputField nameField;
    public InputField passwordField;

    public Button submitButton;

    private bool userNotFound;
    private bool wrongPassword;
    public Text tempName;
    public Text tempPassword;

    public Text usernameError;
    public Text loginError;


    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());
    }

    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("http://kauheaa.com/gigapotato/sqlconnect/login.php", form);
        yield return www;
        if (www.text[0] == '0') //check if first character of string is 0
        {
            usernameError.text = "";
            loginError.text = "";
            DatabaseManager.username = nameField.text;
            DatabaseManager.score = www.text;
            string[] webResults = www.text.Split('3'); // splits the text by character (single quote for character, double for string)
            Debug.Log(webResults[0]); // makes the results an array and posts first item as string
            int webNumber1 = int.Parse(webResults[0]);
            int webNumber2 = int.Parse(webResults[1]);
            int webNumber3 = int.Parse(webResults[2]);
            int webNumber4 = int.Parse(webResults[3]);
            int webNumber5 = int.Parse(webResults[4]);
            int webNumber6 = int.Parse(webResults[5]);
            int webNumber7 = int.Parse(webResults[6]);
            int webNumber8 = int.Parse(webResults[7]);
            int webNumber9 = int.Parse(webResults[8]);
            int webNumber10 = int.Parse(webResults[9]);
            int webNumber11 = int.Parse(webResults[10]);
            int webNumber12 = int.Parse(webResults[11]);
            int webNumber13 = int.Parse(webResults[12]);// turns second string item on array into int
            Debug.Log("webnumbers are " + webNumber1 + ", " + webNumber2 + ", " + webNumber3 + ", " + webNumber4 + ", " + webNumber5 + ", " + webNumber6 + ", " + webNumber7 + ", " + webNumber8 + ", " + webNumber9 + ", " + webNumber10 + ", " + webNumber11 + ", " + webNumber12 + ", " + webNumber13);
            DatabaseManager.appleStickerScore = int.Parse(webResults[1]);
            DatabaseManager.basketStickerScore = int.Parse(webResults[2]);
            DatabaseManager.pigStickerScore = int.Parse(webResults[3]);
            DatabaseManager.carrotStickerScore = int.Parse(webResults[4]);
            DatabaseManager.bucketStickerScore = int.Parse(webResults[5]);
            DatabaseManager.bunnyStickerScore = int.Parse(webResults[6]);
            DatabaseManager.threeCornStickerScore = int.Parse(webResults[7]);
            DatabaseManager.twoCornStickerScore = int.Parse(webResults[8]);
            DatabaseManager.lambStickerScore = int.Parse(webResults[9]);

            DatabaseManager.bananaStickerScore = int.Parse(webResults[10]);
            DatabaseManager.clusterStickerScore = int.Parse(webResults[11]);
            DatabaseManager.monkeyStickerScore = int.Parse(webResults[12]);
            DatabaseManager.coconutStickerScore = int.Parse(webResults[13]);
            DatabaseManager.ocularsStickerScore = int.Parse(webResults[14]);
            DatabaseManager.slothStickerScore = int.Parse(webResults[15]);
            DatabaseManager.lycheeStickerScore = int.Parse(webResults[16]);
            DatabaseManager.pitahayaStickerScore = int.Parse(webResults[17]);
            DatabaseManager.frogStickerScore = int.Parse(webResults[18]);
            DatabaseManager.avocadoStickerScore = int.Parse(webResults[19]);
            DatabaseManager.toolStickerScore = int.Parse(webResults[20]);
            DatabaseManager.tigerStickerScore = int.Parse(webResults[21]);

            DatabaseManager.asteroidStickerScore = int.Parse(webResults[22]);
            DatabaseManager.blackholeStickerScore = int.Parse(webResults[23]);
            DatabaseManager.llamaStickerScore = int.Parse(webResults[24]);
            DatabaseManager.starStickerScore = int.Parse(webResults[25]);
            DatabaseManager.planetStickerScore = int.Parse(webResults[26]);
            DatabaseManager.cowStickerScore = int.Parse(webResults[27]);
            DatabaseManager.flagStickerScore = int.Parse(webResults[28]);
            DatabaseManager.rocketStickerScore = int.Parse(webResults[29]);
            DatabaseManager.laikaStickerScore = int.Parse(webResults[30]);
            DatabaseManager.driedfishStickerScore = int.Parse(webResults[31]);
            DatabaseManager.octopusStickerScore = int.Parse(webResults[32]);
            DatabaseManager.catStickerScore = int.Parse(webResults[33]);
            book.LoadBook();
            book.UpdatePlayerInfo();
            book.OpenFirstSpread();
        }
        else
        {
            if (www.text[0] == '5')
            {
                userNotFound = true;
                tempName.text = nameField.text;
            }
            else
            {
                usernameError.text = "";
            }
            if (www.text[0] == '6')
            {
                wrongPassword = true;
                tempPassword.text = passwordField.text;
            }
            else
            {
                usernameError.text = "";
            }
            Debug.Log("User login failed. Error number #" + www.text);
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 3 && passwordField.text.Length >= 5);
    }

    private void Start()
    {
        usernameError.text = "";
        loginError.text = "";

        nameField.onValidateInput +=
            delegate (string s, int i, char c) { return char.ToUpper(c); };
    }

    private void Update()
    {
        if (userNotFound == true)
        {
            usernameError.text = "USERNAME DOESN'T EXIST";
            if (nameField.text != tempName.text)
            {
                userNotFound = false;
            }
        }
        else
        {
            usernameError.text = "";
        }

        if (wrongPassword == true)
        {
            loginError.text = "INCORRECT PASSWORD";
            if (nameField.text != tempName.text)
            {
                wrongPassword = false;
            }
        }
        else
        {
            loginError.text = "";
        }
    }

}
