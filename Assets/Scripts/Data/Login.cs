using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public StickerBook book;        // stickerbook in the scene
    public SaveDataManager save;    // saveDataManager in the scene
 
    public InputField nameField;
    public InputField passwordField;
    public Button submitButton;

    private bool userNotFound;
    private bool wrongPassword;
    public Text tempName;
    public Text tempPassword;

    public Text usernameError;
    public Text loginError;

    public void CallLogin()     // Sends username and password to PHP and gets back name and score attached to username. Picks score apart into stickerScore ints and updates sticker score to book.
    {
        StartCoroutine(LoginPlayer());
    }

    public void ResetErrors()       // wipes error messages above inputFields
    {
        usernameError.text = "";
        loginError.text = "";
    }

    public void ResetFields()       // resets login form fields
    {
        nameField.text = "";
        passwordField.text = "";
    }


    IEnumerator LoginPlayer()   // Sends username and password to PHP and gets back name and score attached to username. Picks score apart into stickerScore ints and updates sticker score to book.
    {
        WWWForm form = new WWWForm();
        form.AddField("username", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("http://kauheaa.com/gigapotato/sqlconnect/login.php", form);
        yield return www;
        if (www.text[0] == '0') // Check if first character of string is 0 (0 = there were no errors in php)
        {
            ResetErrors();
            DatabaseManager.username = nameField.text;
            ResetFields();
            
            if (www.text != "0")
            {
                DatabaseManager.score = www.text;
                string[] score = www.text.Split('3'); // splits the text by character (single quote for a character, double for string)

                // picks apart saved score string and turns the characters into ints
                DatabaseManager.appleStickerScore = int.Parse(score[1]);
                DatabaseManager.basketStickerScore = int.Parse(score[2]);
                DatabaseManager.pigStickerScore = int.Parse(score[3]);
                DatabaseManager.carrotStickerScore = int.Parse(score[4]);
                DatabaseManager.bucketStickerScore = int.Parse(score[5]);
                DatabaseManager.bunnyStickerScore = int.Parse(score[6]);
                DatabaseManager.threeCornStickerScore = int.Parse(score[7]);
                DatabaseManager.twoCornStickerScore = int.Parse(score[8]);
                DatabaseManager.lambStickerScore = int.Parse(score[9]);
                DatabaseManager.bananaStickerScore = int.Parse(score[10]);
                DatabaseManager.clusterStickerScore = int.Parse(score[11]);
                DatabaseManager.monkeyStickerScore = int.Parse(score[12]);
                DatabaseManager.coconutStickerScore = int.Parse(score[13]);
                DatabaseManager.ocularsStickerScore = int.Parse(score[14]);
                DatabaseManager.slothStickerScore = int.Parse(score[15]);
                DatabaseManager.lycheeStickerScore = int.Parse(score[16]);
                DatabaseManager.pitahayaStickerScore = int.Parse(score[17]);
                DatabaseManager.frogStickerScore = int.Parse(score[18]);
                DatabaseManager.avocadoStickerScore = int.Parse(score[19]);
                DatabaseManager.toolStickerScore = int.Parse(score[20]);
                DatabaseManager.tigerStickerScore = int.Parse(score[21]);
                DatabaseManager.asteroidStickerScore = int.Parse(score[22]);
                DatabaseManager.blackholeStickerScore = int.Parse(score[23]);
                DatabaseManager.llamaStickerScore = int.Parse(score[24]);
                DatabaseManager.starStickerScore = int.Parse(score[25]);
                DatabaseManager.planetStickerScore = int.Parse(score[26]);
                DatabaseManager.cowStickerScore = int.Parse(score[27]);
                DatabaseManager.flagStickerScore = int.Parse(score[28]);
                DatabaseManager.rocketStickerScore = int.Parse(score[29]);
                DatabaseManager.laikaStickerScore = int.Parse(score[30]);
                DatabaseManager.driedfishStickerScore = int.Parse(score[31]);
                DatabaseManager.octopusStickerScore = int.Parse(score[32]);
                DatabaseManager.catStickerScore = int.Parse(score[33]);
            }
            else
            {
                DatabaseManager.score = "3030303030303030303030303030303030303030303030303030303030303030303";
                string[] score = DatabaseManager.score.Split('3'); // splits the text by character (single quote for a character, double for string)
                // picks apart saved score string and turns the characters into ints
                DatabaseManager.appleStickerScore = int.Parse(score[1]);
                DatabaseManager.basketStickerScore = int.Parse(score[2]);
                DatabaseManager.pigStickerScore = int.Parse(score[3]);
                DatabaseManager.carrotStickerScore = int.Parse(score[4]);
                DatabaseManager.bucketStickerScore = int.Parse(score[5]);
                DatabaseManager.bunnyStickerScore = int.Parse(score[6]);
                DatabaseManager.threeCornStickerScore = int.Parse(score[7]);
                DatabaseManager.twoCornStickerScore = int.Parse(score[8]);
                DatabaseManager.lambStickerScore = int.Parse(score[9]);
                DatabaseManager.bananaStickerScore = int.Parse(score[10]);
                DatabaseManager.clusterStickerScore = int.Parse(score[11]);
                DatabaseManager.monkeyStickerScore = int.Parse(score[12]);
                DatabaseManager.coconutStickerScore = int.Parse(score[13]);
                DatabaseManager.ocularsStickerScore = int.Parse(score[14]);
                DatabaseManager.slothStickerScore = int.Parse(score[15]);
                DatabaseManager.lycheeStickerScore = int.Parse(score[16]);
                DatabaseManager.pitahayaStickerScore = int.Parse(score[17]);
                DatabaseManager.frogStickerScore = int.Parse(score[18]);
                DatabaseManager.avocadoStickerScore = int.Parse(score[19]);
                DatabaseManager.toolStickerScore = int.Parse(score[20]);
                DatabaseManager.tigerStickerScore = int.Parse(score[21]);
                DatabaseManager.asteroidStickerScore = int.Parse(score[22]);
                DatabaseManager.blackholeStickerScore = int.Parse(score[23]);
                DatabaseManager.llamaStickerScore = int.Parse(score[24]);
                DatabaseManager.starStickerScore = int.Parse(score[25]);
                DatabaseManager.planetStickerScore = int.Parse(score[26]);
                DatabaseManager.cowStickerScore = int.Parse(score[27]);
                DatabaseManager.flagStickerScore = int.Parse(score[28]);
                DatabaseManager.rocketStickerScore = int.Parse(score[29]);
                DatabaseManager.laikaStickerScore = int.Parse(score[30]);
                DatabaseManager.driedfishStickerScore = int.Parse(score[31]);
                DatabaseManager.octopusStickerScore = int.Parse(score[32]);
                DatabaseManager.catStickerScore = int.Parse(score[33]);
            }
            book.LoadBook();        // book loads scores above and updates all (player info, login buttons, stickers, stars, level buttons)
            book.OpenFirstSpread(); // closes register and login spreads and opens first spread
            book.closeBookButton.interactable = true;
        }
        else
        {
            if (www.text[0] == '5') // php error code 5 = username doesn't exist
            {
                userNotFound = true;
                tempName.text = nameField.text;
            }
            else
            {
                usernameError.text = "";
            }
            if (www.text[0] == '6') // php error code 6 = password was incorrect
            {
                wrongPassword = true;
                tempPassword.text = passwordField.text;
            }
            else
            {
                loginError.text = "";
            }
            Debug.Log("User login failed. Error number #" + www.text);
        }
    }

    // Assign this function to LoginForm Name and Password input fields in inspector
    public void VerifyInputs()      // Makes submitButton interactable when username is >= 3 characters and password >=5
    {
        submitButton.interactable = (nameField.text.Length >= 3 && passwordField.text.Length >= 5);
        book.closeBookButton.interactable = (nameField.text == "DEV");
    }

    public void ForceUppercase()    // forces name field input uppercase
    {
        nameField.onValidateInput += delegate (string s, int i, char c)
        { return char.ToUpper(c); };
    }

    private void Start()
    {
        ResetErrors();      // wipes error messages above inputFields
        ForceUppercase();   // forces name field input uppercase
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
            if (tempPassword.text != passwordField.text)
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
