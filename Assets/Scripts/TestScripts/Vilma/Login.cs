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
            DatabaseManager.score = int.Parse(www.text.Split('\t')[1]);
            Debug.Log(www.text + DatabaseManager.score);
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
